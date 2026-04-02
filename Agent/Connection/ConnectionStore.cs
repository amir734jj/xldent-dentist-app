using SQLite;

namespace Agent.Connection;

public sealed class ConnectionStore : IDisposable
{
    private readonly SQLiteConnection _db;

    public ConnectionStore()
    {
        _db = new SQLiteConnection(DbPath);
        _db.CreateTable<ConnectionProfile>();
        _db.CreateTable<AgentConfig>();
    }

    public static string DbPath
    {
        get
        {
            var dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "xldent");
            Directory.CreateDirectory(dir);
            return Path.Combine(dir, "xldent.db");
        }
    }

    public ConnectionProfile? GetLastUsed()
    {
        return _db.Table<ConnectionProfile>()
            .OrderByDescending(p => p.LastUsed)
            .FirstOrDefault();
    }

    public void SaveProfile(ConnectionProfile profile)
    {
        var existing = _db.Table<ConnectionProfile>().FirstOrDefault(p =>
            p.Server   == profile.Server   &&
            p.Port     == profile.Port     &&
            p.Database == profile.Database &&
            p.Username == profile.Username);

        if (existing is null)
        {
            profile.LastUsed = DateTime.UtcNow;
            _db.Insert(profile);
        }
        else
        {
            existing.Password = profile.Password;
            existing.LastUsed = DateTime.UtcNow;
            _db.Update(existing);
        }
    }

    public AgentConfig? GetAgentConfig()
    {
        return _db.Table<AgentConfig>().FirstOrDefault();
    }

    public void SaveAgentConfig(AgentConfig config)
    {
        config.Id = 1;
        _db.InsertOrReplace(config);
    }

    public void Dispose()
    {
        _db.Dispose();
    }
}
