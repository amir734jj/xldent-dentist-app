using System.Reflection;
using ConsoleApp.Connection;
using Data;
using Data.Interfaces;
using Data.Queries;
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

using var scope = provider.CreateScope();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
var service = scope.ServiceProvider.GetRequiredService<IPatientAppointmentService>();

logger.LogInformation("Searching for patients with name {Name}", "Hesamian");

var results = await service.SearchAsync(new PatientSearchParams { Name = "Hesamian" });

logger.LogInformation("Patient: {0}", results);