using System.Diagnostics;
using System.Runtime.InteropServices;
using Serilog;

namespace Agent;

internal static class ServiceInstaller
{
    private const string ServiceName = "XLDentAgent";
    private const string DisplayName = "XLDent Agent";
    private const string Description = "XLDent dental clinic agent — relays queries via the XLDent API hub.";

    public static void Install()
    {
        var exe = Process.GetCurrentProcess().MainModule?.FileName
            ?? throw new InvalidOperationException("Cannot determine the executable path.");

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            InstallWindows(exe);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            InstallLinux(exe);
        }
        else
        {
            Die("Service installation is only supported on Windows and Linux.");
        }
    }

    public static void Uninstall()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            UninstallWindows();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            UninstallLinux();
        }
        else
        {
            Die("Service installation is only supported on Windows and Linux.");
        }
    }

    private static void InstallWindows(string exe)
    {
        Log.Information("Installing Windows service '{ServiceName}'…", ServiceName);
        Run("sc.exe", $"create {ServiceName} binPath= \"\"{exe}\"\" start= delayed-auto DisplayName= \"{DisplayName}\"");
        Run("sc.exe", $"description {ServiceName} \"{Description}\"");
        Run("sc.exe", $"failure {ServiceName} reset= 60 actions= restart/10000/restart/30000/restart/60000");
        Run("sc.exe", $"failureflag {ServiceName} 1");
        Run("sc.exe", $"start {ServiceName}");
        Log.Information("Done. Service '{ServiceName}' installed and started.", ServiceName);
        Log.Information("Run interactively once first (without --install-service) to save your connection config.");
    }

    private static void UninstallWindows()
    {
        Log.Information("Removing Windows service '{ServiceName}'…", ServiceName);
        Run("sc.exe", $"stop {ServiceName}");
        Run("sc.exe", $"delete {ServiceName}");
        Log.Information("Done. Service '{ServiceName}' removed.", ServiceName);
    }

    private static void InstallLinux(string exe)
    {
        var unitDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".config", "systemd", "user");
        Directory.CreateDirectory(unitDir);

        var unitPath = Path.Combine(unitDir, $"{ServiceName}.service");
        File.WriteAllText(unitPath,
            $"""
            [Unit]
            Description={Description}
            After=network-online.target
            Wants=network-online.target

            [Service]
            ExecStart={exe}
            Restart=always
            RestartSec=10
            RestartPreventExitStatus=

            [Install]
            WantedBy=default.target
            """);

        Log.Information("Written unit file: {UnitPath}", unitPath);
        Run("systemctl", "--user daemon-reload");
        Run("systemctl", $"--user enable --now {ServiceName}");
        Log.Information("Done. Systemd user service '{ServiceName}' installed and started.", ServiceName);
        Log.Information("Tip: run 'loginctl enable-linger $USER' to keep it alive after logout.");
    }

    private static void UninstallLinux()
    {
        Run("systemctl", $"--user disable --now {ServiceName}");

        var unitPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".config", "systemd", "user", $"{ServiceName}.service");
        if (File.Exists(unitPath))
        {
            File.Delete(unitPath);
            Log.Information("Deleted: {UnitPath}", unitPath);
        }

        Run("systemctl", "--user daemon-reload");
        Log.Information("Done. Service '{ServiceName}' removed.", ServiceName);
    }

    public static bool IsInstalled()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var psi = new ProcessStartInfo("sc.exe", $"query {ServiceName}")
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            using var p = Process.Start(psi)!;
            p.WaitForExit();
            return p.ExitCode == 0;
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            var unitPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".config", "systemd", "user", $"{ServiceName}.service");
            return File.Exists(unitPath);
        }

        return false;
    }

    private static void Run(string cmd, string arguments)
    {
        var psi = new ProcessStartInfo(cmd, arguments)
        {
            UseShellExecute        = false,
            RedirectStandardOutput = true,
            RedirectStandardError  = true
        };

        using var process = Process.Start(psi) ?? throw new InvalidOperationException($"Failed to start {cmd}");
        var stdout = process.StandardOutput.ReadToEnd().Trim();
        var stderr = process.StandardError.ReadToEnd().Trim();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(stdout))
        {
            Log.Information("{Output}", stdout);
        }

        if (!string.IsNullOrEmpty(stderr))
        {
            Log.Warning("{Stderr}", stderr);
        }
    }

    private static void Die(string message)
    {
        Log.Fatal("{Message}", message);
        Log.CloseAndFlush();
        Environment.Exit(1);
    }
}
