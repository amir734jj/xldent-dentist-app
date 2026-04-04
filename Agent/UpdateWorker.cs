using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shared;
using Velopack;
using Velopack.Sources;

namespace Agent;

public sealed class UpdateWorker(ILogger<UpdateWorker> logger) : BackgroundService
{
    private static readonly TimeSpan CheckInterval = TimeSpan.FromHours(1);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(CheckInterval, stoppingToken);
            await TryApplyUpdateAsync();
        }
    }

    private async Task TryApplyUpdateAsync()
    {
        try
        {
            var mgr = new UpdateManager(new GithubSource(AppConstants.GitHubRepoUrl, null, false));
            var newVersion = await mgr.CheckForUpdatesAsync();
            if (newVersion is null)
            {
                return;
            }

            logger.LogInformation("Update available: v{Version}. Downloading…", newVersion.TargetFullRelease.Version);
            await mgr.DownloadUpdatesAsync(newVersion);
            logger.LogInformation("Update downloaded. Exiting for service manager to restart with v{Version}.", newVersion.TargetFullRelease.Version);

            // Exit cleanly — the SCM restart policy brings the service back up with the new binary.
            mgr.ApplyUpdatesAndExit(newVersion);
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "Update check failed");
        }
    }
}
