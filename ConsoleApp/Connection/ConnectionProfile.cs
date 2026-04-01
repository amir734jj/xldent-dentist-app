using System.Data.Common;
using LiteDB;

namespace ConsoleApp.Connection;

/// <summary>LiteDB document that stores one MySQL connection profile.</summary>
public sealed class ConnectionProfile
{
    [BsonId]
    public int Id { get; set; }

    public required string Server   { get; set; }
    public required int    Port     { get; set; }
    public required string Database { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }

    /// <summary>UTC timestamp updated every time this profile is picked or saved.</summary>
    public DateTimeOffset LastUsed { get; set; }

    /// <summary>Builds a safe MySql.EntityFrameworkCore connection string, escaping special characters in values.</summary>
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
