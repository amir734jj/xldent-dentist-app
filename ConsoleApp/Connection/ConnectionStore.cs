using LiteDB;

namespace ConsoleApp.Connection;

/// <summary>
/// Persists MySQL connection profiles to a local LiteDB database.
/// Self-contained — no EF Core or DI required. Safe to instantiate
/// both before and inside the DI container.
///
/// Database location:
///   Windows : %APPDATA%\xldent\xldent.db
///   Linux   : ~/.config/xldent/xldent.db
///   macOS   : ~/Library/Application Support/xldent/xldent.db
/// </summary>
public sealed class ConnectionStore : IDisposable
{
    private readonly LiteDatabase _db = new(DbPath);
    private ILiteCollection<ConnectionProfile> Profiles => _db.GetCollection<ConnectionProfile>("profiles");

    /// <summary>Absolute path to the LiteDB file.</summary>
    public static string DbPath
    {
        get
        {
            var dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "xldent");
            Directory.CreateDirectory(dir);
            return Path.Combine(dir, "xldent.litedb");
        }
    }

    /// <summary>Returns the most recently used profile, or <c>null</c> if none saved.</summary>
    public ConnectionProfile? GetLastUsed()
        => Profiles.Query()
                   .OrderByDescending(p => p.LastUsed)
                   .FirstOrDefault();

    /// <summary>
    /// Saves a new profile or updates the password and <c>LastUsed</c> timestamp
    /// of an existing one (matched on Server + Port + Database + Username).
    /// </summary>
    public void SaveProfile(ConnectionProfile profile)
    {
        var existing = Profiles.FindOne(p =>
            p.Server   == profile.Server   &&
            p.Port     == profile.Port     &&
            p.Database == profile.Database &&
            p.Username == profile.Username);

        if (existing is null)
        {
            profile.LastUsed = DateTimeOffset.UtcNow;
            Profiles.Insert(profile);
        }
        else
        {
            existing.Password = profile.Password;
            existing.LastUsed = DateTimeOffset.UtcNow;
            Profiles.Update(existing);
        }
    }

    public void Dispose() => _db.Dispose();
}
