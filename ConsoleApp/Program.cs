using System.Reflection;
using ConsoleApp.Connection;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Velopack;

VelopackApp.Build().Run();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
    .WriteTo.File(
        path: "logs/app-.log",
        rollingInterval: RollingInterval.Day,
        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

await UpdateService.CheckAndApplyUpdatesAsync();

string connectionString;
var envUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

if (!string.IsNullOrWhiteSpace(envUrl))
{
    connectionString = envUrl;
    Log.Information("Using connection from DATABASE_URL environment variable");
}
else
{
    using var store = new ConnectionStore();
    var saved = store.GetLastUsed();
    var profile = ConnectionSetup.Prompt(saved);
    store.SaveProfile(profile);
    connectionString = profile.ToConnectionString();
}

var services = new ServiceCollection();

services.AddLogging(logging =>
{
    logging.ClearProviders();
    logging.AddSerilog(dispose: true);
});

services.AddSingleton<ConnectionStore>();

services.AddDbContext<DrDataContext>(options =>
    options.UseMySQL(connectionString));

services.Scan(scan => scan
    .FromAssemblies(Assembly.Load("Data"))
    .AddClasses()
    .AsImplementedInterfaces()
    .WithScopedLifetime());

await using var provider = services.BuildServiceProvider();

var hubUrl = Environment.GetEnvironmentVariable("AGENT_HUB_URL")
    ?? "http://localhost:5097/hubs/agent";
var agentId = Environment.GetEnvironmentVariable("AGENT_ID") ?? "clinic-1";
var apiKey  = Environment.GetEnvironmentVariable("AGENT_API_KEY") ?? "REPLACE-WITH-AGENT-API-KEY";

using var cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, e) => { e.Cancel = true; cts.Cancel(); };

await using var agent = new AgentConnection(hubUrl, agentId, apiKey, provider);
await agent.StartAsync(cts.Token);

Log.Information("Agent running. Press Ctrl+C to exit.");
try { await Task.Delay(Timeout.Infinite, cts.Token); }
catch (OperationCanceledException) { }

Log.Information("Agent stopped.");

