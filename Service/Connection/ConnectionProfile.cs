using System.Data.Common;
using LiteDB;

namespace Service.Connection;

public sealed class ConnectionProfile
{
    [BsonId]
    public int Id { get; set; }

    public required string Server   { get; set; }
    public required int    Port     { get; set; }
    public required string Database { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }

    public DateTimeOffset LastUsed { get; set; }

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
