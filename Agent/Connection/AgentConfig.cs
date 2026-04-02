using LiteDB;

namespace Agent.Connection;

public sealed class AgentConfig
{
    [BsonId]
    public int Id { get; set; }

    public required string HubUrl  { get; set; }
    public required string AgentId { get; set; }
    public required string ApiKey  { get; set; }
}
