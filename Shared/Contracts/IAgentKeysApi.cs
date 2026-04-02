using Refit;

namespace Shared.Contracts;

[Headers("Authorization: Bearer")]
public interface IAgentKeysApi
{
    [Get("/api/agent-keys")]
    Task<List<AgentKeyDto>> GetAllAsync();

    [Post("/api/agent-keys")]
    Task<AgentKeyDto> CreateAsync([Body] CreateAgentKeyRequest request);

    [Delete("/api/agent-keys/{agentId}")]
    Task DeleteAsync(string agentId);
}
