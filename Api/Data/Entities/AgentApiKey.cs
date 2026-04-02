using Api.Interfaces;

namespace Api.Data.Entities;

public sealed class AgentApiKey : IEntity
{
    /// <summary>The API key — also serves as the primary key.</summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid   UserId     { get; set; }
    public User? User { get; set; }

    public string AgentId    { get; set; } = string.Empty;
    public string ClinicName { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
