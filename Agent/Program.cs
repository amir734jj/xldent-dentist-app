using System.Reflection;
using CommandLine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Systemd;
using Microsoft.Extensions.Hosting.WindowsServices;
using Serilog;
using Agent;
using Agent.Commands;
using Agent.Connection;
using Velopack;
using XLDENTProxy;

VelopackApp.Build().Run();

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true)
    .AddJsonFile("appsettings.Production.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

var loggerConfig = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
    .WriteTo.File(
        path: "logs/app-.log",
        rollingInterval: RollingInterval.Day,
        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}");

#if !DEBUG
var sentryDsn = configuration["Sentry:Dsn"];
if (!string.IsNullOrWhiteSpace(sentryDsn))
{
    loggerConfig.WriteTo.Sentry(
        dsn: sentryDsn,
        restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error);
}
#endif

Log.Logger = loggerConfig.CreateLogger();

var isService = WindowsServiceHelpers.IsWindowsService() || SystemdHelpers.IsSystemdService();

var handled = false;
Parser.Default
    .ParseArguments<RunOptions, InstallServiceOptions, UninstallServiceOptions>(args)
    .WithParsed<InstallServiceOptions>(_   => { ServiceInstaller.Install();   handled = true; })
    .WithParsed<UninstallServiceOptions>(_ => { ServiceInstaller.Uninstall(); handled = true; });

if (handled)
{
    Log.Fatal("Unhandled exception occurred during installation.");
    return;
}

if (!isService)
{
    await UpdateService.CheckAndApplyUpdatesAsync();
}

string connectionString;
var envUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

if (!string.IsNullOrWhiteSpace(envUrl))
{
    connectionString = ConnectionProfile.WithZeroDateTimeFlags(envUrl);
    Log.Information("Using connection from DATABASE_URL environment variable");
}
else if (isService)
{
    using var store = new ConnectionStore();
    var saved = store.GetLastUsed();
    if (saved is null)
    {
        Log.Fatal("No saved MySQL connection. Run the app interactively first to configure it, then re-install the service.");
        return;
    }
    connectionString = saved.ToConnectionString();
    Log.Information("Using saved MySQL connection: {Server}:{Port}/{Database}", saved.Server, saved.Port, saved.Database);
}
else
{
    using var store = new ConnectionStore();
    var saved = store.GetLastUsed();
    var profile = ConnectionSetup.Prompt(saved);
    store.SaveProfile(profile);
    connectionString = profile.ToConnectionString();
}

AgentConfig agentConfig;
if (isService)
{
    using var configStore = new ConnectionStore();
    var saved = configStore.GetAgentConfig();
    if (saved is null)
    {
        Log.Fatal("No saved agent config. Run the app interactively first to configure it, then re-install the service.");
        return;
    }
    agentConfig = saved;
    Log.Information("Using saved agent config: {AgentId} → {ServerUrl}", agentConfig.AgentId, agentConfig.ServerUrl);
}
else
{
    using var configStore = new ConnectionStore();
    var savedConfig = configStore.GetAgentConfig();
    agentConfig = AgentSetup.Prompt(savedConfig);
    configStore.SaveAgentConfig(agentConfig);
}

var host = new HostBuilder()
    .UseContentRoot(AppContext.BaseDirectory)
    .ConfigureAppConfiguration(c => c.AddConfiguration(configuration))
    .UseSerilog()
    .UseWindowsService(options => options.ServiceName = "XLDentAgent")
    .UseSystemd()
    .ConfigureServices((_, svc) =>
    {
        svc.AddSingleton(agentConfig);
        svc.AddDbContext<DrDataContext>(options =>
            options.UseMySQL(connectionString));

        svc.Scan(scan => scan
            .FromAssemblies(Assembly.Load("XLDENTProxy"))
            .AddClasses()
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        svc.AddHostedService<AgentWorker>();
        if (isService)
        {
            svc.AddHostedService<UpdateWorker>();
        }
    })
    .Build();

try
{
    await host.RunAsync();
}
finally
{
    await Log.CloseAndFlushAsync();
}
