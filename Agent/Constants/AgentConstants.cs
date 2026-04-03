namespace Agent.Constants;

public static class AgentConstants
{
#if DEBUG
    public const string DefaultServerUrl = "http://localhost:5000";
#else
    public const string DefaultServerUrl = "https://xldent-2817cc321818.herokuapp.com";
#endif
    public const string DefaultAgentId = "clinic-1";
}
