using SQLite;

namespace Agent.Connection;

public sealed class AgentConfig
{
    [PrimaryKey]
    public int Id { get; set; }

    public string ServerUrl { get; set; } = string.Empty;
    public string AgentId { get; set; } = string.Empty;
    public string ApiKey  { get; set; } = string.Empty;
}
