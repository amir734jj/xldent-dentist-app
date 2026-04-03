using Blazored.LocalStorage;
using Havit.Blazor.Components.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;
using Serilog;
using Serilog.Events;
using Shared.Contracts;
using UI;
using UI.Services;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .MinimumLevel.Override("System.Net.Http", LogEventLevel.Warning)
    .WriteTo.BrowserConsole(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Logging.AddSerilog(dispose: true);

var apiBaseUrl = builder.Configuration["ApiBaseUrl"];
if (string.IsNullOrEmpty(apiBaseUrl))
{
    apiBaseUrl = builder.HostEnvironment.BaseAddress;
}

builder.Services.AddSingleton<AuthService>();
builder.Services.AddTransient<BearerTokenHandler>();

builder.Services
    .AddRefitClient<IAuthApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl));

builder.Services
    .AddRefitClient<IAgentsApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl))
    .AddHttpMessageHandler<BearerTokenHandler>();

builder.Services
    .AddRefitClient<IAgentKeysApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl))
    .AddHttpMessageHandler<BearerTokenHandler>();

builder.Services
    .AddRefitClient<IUsersApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl))
    .AddHttpMessageHandler<BearerTokenHandler>();

builder.Services.AddScoped<ApiService>();
builder.Services.AddBlazoredLocalStorageAsSingleton();
builder.Services.AddHxServices();
builder.Services.AddHxMessenger();

var host = builder.Build();

var auth = host.Services.GetRequiredService<AuthService>();
await auth.InitAsync();

await host.RunAsync();
