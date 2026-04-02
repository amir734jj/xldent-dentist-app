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
            ["server"]              = Server,
            ["port"]                = Port,
            ["database"]            = Database,
            ["uid"]                 = Username,
            ["pwd"]                 = Password,
            ["ConvertZeroDateTime"] = "True",
            ["AllowZeroDateTime"]   = "True"
        };
        return builder.ConnectionString;
    }

    /// <summary>
    /// Ensures ConvertZeroDateTime and AllowZeroDateTime are set on any connection string,
    /// so that MySQL zero-date values (0000-00-00) map to DateTime.MinValue instead of throwing.
    /// </summary>
    public static string WithZeroDateTimeFlags(string connectionString)
    {
        var builder = new DbConnectionStringBuilder { ConnectionString = connectionString };
        if (!builder.ContainsKey("ConvertZeroDateTime"))
        {
            builder["ConvertZeroDateTime"] = "True";
        }

        if (!builder.ContainsKey("AllowZeroDateTime"))
        {
            builder["AllowZeroDateTime"] = "True";
        }

        return builder.ConnectionString;
    }
}
