using FightingFlowDotNet.Auth;
using FightingFlowDotNet.Components;
using Supabase;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("customsettings.json", optional:false, reloadOnChange:true);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped(provider =>
{
    var url = builder.Configuration["Supabase:Url"];
    var key = builder.Configuration["Supabase:Key"];
    var options = new SupabaseOptions
    {
        AutoRefreshToken = true,
        AutoConnectRealtime = true
    };
    
    return new Supabase.Client(url, key, options);
});

builder.Services.AddScoped<AuthHandler>();

builder.Services.AddHttpClient("MyApi", client =>
    {
        client.BaseAddress = new Uri("https://localhost:7127");
    })
    .AddHttpMessageHandler<AuthHandler>();

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

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();