using System.Security.Claims;
using System.Threading.RateLimiting;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using FightingFlowDotNet.Clients;
using FightingFlowDotNet.Clients.Helper;
using FightingFlowDotNet.Components;
using FightingFlowDotNet.Models;
using FightingFlowDotNet.Models.State;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.RateLimiting;

var builder = WebApplication.CreateBuilder(args);
if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddJsonFile("customsettings.json", optional: false, reloadOnChange: true);
}

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddSingleton(sp =>
{
    var credential = GoogleCredentialFactory.Create(
        sp.GetRequiredService<IConfiguration>(),
        sp.GetRequiredService<IHostEnvironment>());
    
    return FirebaseApp.Create(new AppOptions { Credential = credential });
});

builder.Services.AddSingleton(sp => FirebaseAuth.GetAuth(sp.GetRequiredService<FirebaseApp>()));

builder.Services.AddScoped<FirebaseAuthVerifier>();
builder.Services.AddScoped<FirebaseClientFactory>();
builder.Services.AddScoped<UserData>();
builder.Services.AddScoped<FirestoreGetter>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<GameSelectedState>();

builder.Services.AddBlazorise(options =>
    {
        options.Immediate = true;
        options.ProductToken = builder.Environment.IsProduction() ? 
            Environment.GetEnvironmentVariable("BLAZORKEY")?.Trim() : 
            builder.Configuration["Blazorise:ProductKey"];
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

builder.Services.AddRateLimiter(options =>
{
    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

    options.AddFixedWindowLimiter("signup", opt =>
    {
        opt.PermitLimit = 3;
        opt.Window = TimeSpan.FromMinutes(3);
        opt.QueueLimit = 0;
    });

    options.AddFixedWindowLimiter("auth", opt =>
    {
        opt.PermitLimit = 10;
        opt.Window = TimeSpan.FromMinutes(1);
        opt.QueueLimit = 0;
    });

    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
    {
        var path = httpContext.Request.Path;
        var isBlazorOrStaticRequest =
            path.StartsWithSegments("/_blazor") ||
            path.StartsWithSegments("/_framework") ||
            path.StartsWithSegments("/_content") ||
            path.StartsWithSegments("/images") ||
            path.StartsWithSegments("/css") ||
            path == "/favicon.png";

        if (isBlazorOrStaticRequest)
            return RateLimitPartition.GetNoLimiter("blazor-or-static");

        return RateLimitPartition.GetFixedWindowLimiter(
            httpContext.Connection.RemoteIpAddress?.ToString() ?? "Unknown", _ =>
                new FixedWindowRateLimiterOptions
                {
                    // Keep ordinary browsing usable while still limiting sustained abuse.
                    PermitLimit = 300,
                    Window = TimeSpan.FromMinutes(1),
                    QueueLimit = 20,
                    QueueProcessingOrder = QueueProcessingOrder.OldestFirst
                });
    });
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(options =>
    {
        options.MaxBufferedUnacknowledgedRenderBatches = 10;
        options.DisconnectedCircuitMaxRetained = 100;
        options.DisconnectedCircuitRetentionPeriod = TimeSpan.FromMinutes(3);
        options.JSInteropDefaultCallTimeout = TimeSpan.FromSeconds(30);
    });

builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxConcurrentConnections = 200;
    options.Limits.MaxConcurrentUpgradedConnections = 200;
    options.Limits.MaxRequestBodySize = 1 * 1024 * 1024; // 1MB
    options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(2);
    options.Limits.RequestHeadersTimeout = TimeSpan.FromSeconds(30);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.UseRateLimiter();

app.MapPost("/auth/signin", async (HttpContext http, FirebaseAuthVerifier verifier) =>
{
    using var reader = new StreamReader(http.Request.Body);
    var idToken = await reader.ReadToEndAsync();

    var token = await verifier.TryVerifyAsync(idToken);
    if (token is null) return Results.Unauthorized();

    var claims = new List<Claim>
    {
        new(ClaimTypes.NameIdentifier, token.Uid),
        new(ClaimTypes.Email, token.Claims.GetValueOrDefault("email")?.ToString() ?? "")
    };
    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
    await http.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

    return Results.Ok();
}).RequireRateLimiting("auth");

app.MapPost("auth/signout", async (HttpContext http) =>
{
    await http.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    return Results.Ok();
}).RequireRateLimiting("auth");

app.MapPost("auth/signup", async (AuthoriseUser user, FirebaseAuth fbAuth, FirestoreGetter fGetter) =>
{
    var userRecord = await fbAuth.CreateUserAsync(new UserRecordArgs
    {
        Email = user.CustomUserInfo.Email,
        Password = user.Password
    });

    await fGetter.PostUser(user.CustomUserInfo);

    var customToken = await fbAuth.CreateCustomTokenAsync(userRecord.Uid);
    return Results.Ok(new { customToken});
}).RequireRateLimiting("signup");

app.Run();
