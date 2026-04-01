using Serilog;
using Spectre.Console;
using Velopack;
using Velopack.Sources;

namespace ConsoleApp.Connection;

/// <summary>
/// Checks GitHub Releases for a newer version of the app and, when one is
/// available, lets the user apply the update before the session starts.
///
/// Set <see cref="GitHubRepoUrl"/> to your repository URL once you have one.
/// Leave it as-is (null / empty) to skip update checks silently.
/// </summary>
public static class UpdateService
{
    /// <summary>
    /// Replace this with your GitHub repository URL, e.g.
    ///   "https://github.com/your-username/xldent-dentist-app"
    /// Leave null or empty to disable auto-update.
    /// </summary>
    private const string GitHubRepoUrl = "https://github.com/amir734jj/xldent-dentist-app"; // TODO: set your repo URL

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
