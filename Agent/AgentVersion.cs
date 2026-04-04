using System.Reflection;
using Velopack.Locators;

namespace Agent;

internal static class AgentVersion
{
    /// <summary>
    /// Returns the Velopack-installed version, falling back to the assembly version
    /// when running outside a Velopack installation.
    /// </summary>
    public static string Get() =>
        VelopackLocator.Current?.CurrentlyInstalledVersion?.ToString()
        ?? Assembly.GetEntryAssembly()?.GetName().Version?.ToString()
        ?? "unknown";

    public static DateTimeOffset? GetBuildDate()
    {
        var path = Assembly.GetEntryAssembly()?.Location;
        if (string.IsNullOrEmpty(path) || !File.Exists(path))
            return null;
        return new DateTimeOffset(new FileInfo(path).LastWriteTimeUtc, TimeSpan.Zero);
    }
}
