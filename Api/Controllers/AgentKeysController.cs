using System.Security.Claims;
using System.Text.RegularExpressions;
using Api.Data.Entities;
using EfCoreRepository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Contracts;
using EfCoreRepository.Extensions;

namespace Api.Controllers;

[ApiController]
[Route("api/agent-keys")]
[Authorize]
public sealed partial class AgentKeysController(IEfRepository repository) : ControllerBase
{
    private IBasicCrud<AgentApiKey> AgentApiKeysDal => repository.For<AgentApiKey>();

    private bool IsAdmin => User.IsInRole(Roles.Admin);

    private Guid CurrentUserId =>
        Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)
                   ?? User.FindFirstValue("sub")
                   ?? throw new InvalidOperationException("User ID claim missing."));

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var keys = IsAdmin switch
        {
            true => await AgentApiKeysDal.GetAll(project: k => new AgentKeyDto(k.AgentId, k.Id, k.CreatedAt)),
            _ => await AgentApiKeysDal.GetAll(filterExprs: [k => k.UserId == CurrentUserId],
                project: k => new AgentKeyDto(k.AgentId, k.Id, k.CreatedAt))
        };
        return Ok(keys);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAgentKeyRequest req)
    {
        if (string.IsNullOrWhiteSpace(req.AgentId) ||
            !AgentIdRegex().IsMatch(req.AgentId))
        {
            return BadRequest("Agent ID must start with a letter or digit and may only contain letters, digits, and hyphens.");
        }

        if (await AgentApiKeysDal.Any([k => k.AgentId == req.AgentId]))
        {
            return Conflict($"Agent '{req.AgentId}' already exists.");
        }

        var key = new AgentApiKey
        {
            UserId    = CurrentUserId,
            AgentId   = req.AgentId,
            CreatedAt = DateTimeOffset.UtcNow
        };

        await AgentApiKeysDal.Save(key);

        return Ok(new AgentKeyDto(key.AgentId, key.Id, key.CreatedAt));
    }

    [HttpDelete("{agentId}")]
    public async Task<IActionResult> Delete(string agentId)
    {
        var userId = CurrentUserId;
        var keys = (await AgentApiKeysDal.GetAll(filterExprs: [
            k => k.AgentId == agentId && k.UserId == userId
        ], maxResults: 1)).ToList();
        
        if (keys.Count == 0)
        {
            return NotFound();
        }

        await AgentApiKeysDal.Delete(keys.First().Id);

        return NoContent();
    }

    [GeneratedRegex(@"^[a-zA-Z0-9][a-zA-Z0-9-]*$")]
    private static partial Regex AgentIdRegex();
}
