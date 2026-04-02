using System.Diagnostics;
using System.Runtime.InteropServices;

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
        Console.WriteLine($"Installing Windows service '{ServiceName}'…");
        Run("sc.exe", $"create {ServiceName} binPath= \"\"{exe}\"\" start= delayed-auto DisplayName= \"{DisplayName}\"");
        Run("sc.exe", $"description {ServiceName} \"{Description}\"");
        Run("sc.exe", $"failure {ServiceName} reset= 60 actions= restart/10000/restart/30000/restart/60000");
        Run("sc.exe", $"failureflag {ServiceName} 1");
        Run("sc.exe", $"start {ServiceName}");
        Console.WriteLine($"Done. Service '{ServiceName}' installed and started.");
        Console.WriteLine("Run interactively once first (without --install-service) to save your connection config.");
    }

    private static void UninstallWindows()
    {
        Console.WriteLine($"Removing Windows service '{ServiceName}'…");
        Run("sc.exe", $"stop {ServiceName}");
        Run("sc.exe", $"delete {ServiceName}");
        Console.WriteLine($"Done. Service '{ServiceName}' removed.");
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

        Console.WriteLine($"Written unit file: {unitPath}");
        Run("systemctl", "--user daemon-reload");
        Run("systemctl", $"--user enable --now {ServiceName}");
        Console.WriteLine($"Done. Systemd user service '{ServiceName}' installed and started.");
        Console.WriteLine("Tip: run 'loginctl enable-linger $USER' to keep it alive after logout.");
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
            Console.WriteLine($"Deleted: {unitPath}");
        }

        Run("systemctl", "--user daemon-reload");
        Console.WriteLine($"Done. Service '{ServiceName}' removed.");
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
            Console.WriteLine(stdout);
        }

        if (!string.IsNullOrEmpty(stderr))
        {
            Console.Error.WriteLine(stderr);
        }
    }

    private static void Die(string message)
    {
        Console.Error.WriteLine(message);
        Environment.Exit(1);
    }
}
