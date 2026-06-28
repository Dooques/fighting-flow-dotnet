using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using FightingFlowDotNet.Clients;
using FightingFlowDotNet.Components;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("customsettings.json", optional: false, reloadOnChange: true);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddScoped<FirebaseClientFactory>();
builder.Services.AddScoped<UserData>();
builder.Services.AddScoped<FirestoreGetter>();

builder.Services.AddBlazorise(options =>
    {
        options.Immediate = true;
        options.ProductToken = builder.Environment.IsProduction() ? 
            Environment.GetEnvironmentVariable("BLAZORKEY")?.Trim() : 
            builder.Configuration["Blazorise:ProductKey"];
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

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