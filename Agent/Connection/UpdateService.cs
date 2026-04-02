using Serilog;
using Spectre.Console;
using Velopack;
using Velopack.Sources;

namespace Agent.Connection;

public static class UpdateService
{
    private const string GitHubRepoUrl = "https://github.com/amir734jj/xldent-dentist-app";

    public static async Task CheckAndApplyUpdatesAsync()
    {
        if (string.IsNullOrWhiteSpace(GitHubRepoUrl))
        {
            return;
        }

        try
        {
            var mgr        = new UpdateManager(new GithubSource(GitHubRepoUrl, null, false));
            var newVersion = await mgr.CheckForUpdatesAsync();

            if (newVersion is null)
            {
                Log.Information("App is up to date");
                return;
            }

            AnsiConsole.MarkupLine(
                $"[yellow]Update available:[/] v{newVersion.TargetFullRelease.Version}");

            if (!await AnsiConsole.ConfirmAsync("Download and install update now?", defaultValue: true))
            {
                return;
            }

            await AnsiConsole
                .Progress()
                .StartAsync(async ctx =>
                {
                    var task = ctx.AddTask("[green]Downloading update…[/]");
                    await mgr.DownloadUpdatesAsync(newVersion, p => task.Value = p);
                    task.Value = 100;
                });

            AnsiConsole.MarkupLine("[bold green]Update downloaded. Restarting…[/]");
            mgr.ApplyUpdatesAndRestart(newVersion);
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "Update check failed — continuing without update");
        }
    }
}
