using System.Data.Common;
using SQLite;

namespace Agent.Connection;

public sealed class ConnectionProfile
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Server   { get; set; } = string.Empty;
    public int    Port     { get; set; }
    public string Database { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public DateTime LastUsed { get; set; }

    public string ToConnectionString()
    {
        var builder = new DbConnectionStringBuilder
        {
            ["server"]   = Server,
            ["port"]     = Port,
            ["database"] = Database,
            ["uid"]      = Username,
            ["pwd"]      = Password
        };
        return builder.ConnectionString;
    }
}
