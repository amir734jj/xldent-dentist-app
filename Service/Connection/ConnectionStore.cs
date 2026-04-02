using LiteDB;

namespace Service.Connection;

public sealed class ConnectionStore : IDisposable
{
    private readonly LiteDatabase _db = new(DbPath);
    private ILiteCollection<ConnectionProfile> Profiles     => _db.GetCollection<ConnectionProfile>("profiles");
    private ILiteCollection<AgentConfig>        AgentConfigs => _db.GetCollection<AgentConfig>("agent_config");

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

    public ConnectionProfile? GetLastUsed()
        => Profiles.Query()
                   .OrderByDescending(p => p.LastUsed)
                   .FirstOrDefault();

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

    public AgentConfig? GetAgentConfig()
        => AgentConfigs.FindById(1);

    public void SaveAgentConfig(AgentConfig config)
    {
        config.Id = 1;
        AgentConfigs.Upsert(config);
    }

    public void Dispose() => _db.Dispose();
}
