namespace Agent.Constants;

public static class AgentConstants
{
#if DEBUG
    public const string DefaultHubUrl = "http://localhost:5000/hubs/agent";
#else
    public const string DefaultHubUrl = "https://xldent-2817cc321818.herokuapp.com/hubs/agent";
#endif
    public const string DefaultAgentId = "clinic-1";
}
