using System.Security.Claims;
using Api.Data;
using Api.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/agent-keys")]
[Authorize]
public sealed class AgentKeysController(AppDbContext db) : ControllerBase
{
    private Guid CurrentUserId =>
        Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? User.FindFirstValue("sub")
            ?? throw new InvalidOperationException("User ID claim missing."));

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var userId = CurrentUserId;
        var keys = await db.AgentApiKeys
            .Where(k => k.UserId == userId)
            .Select(k => new AgentKeyDto(k.AgentId, k.ClinicName, k.Id, k.CreatedAt))
            .ToListAsync();
        return Ok(keys);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAgentKeyRequest req)
    {
        if (await db.AgentApiKeys.AnyAsync(k => k.AgentId == req.AgentId))
            return Conflict($"Agent '{req.AgentId}' already exists.");

        var key = new AgentApiKey
        {
            UserId     = CurrentUserId,
            AgentId    = req.AgentId,
            ClinicName = req.ClinicName,
            CreatedAt  = DateTimeOffset.UtcNow
        };

        db.AgentApiKeys.Add(key);
        await db.SaveChangesAsync();

        return Ok(new AgentKeyDto(key.AgentId, key.ClinicName, key.Id, key.CreatedAt));
    }

    [HttpDelete("{agentId}")]
    public async Task<IActionResult> Delete(string agentId)
    {
        var userId = CurrentUserId;
        var key = await db.AgentApiKeys
            .FirstOrDefaultAsync(k => k.AgentId == agentId && k.UserId == userId);
        if (key is null) return NotFound();

        db.AgentApiKeys.Remove(key);
        await db.SaveChangesAsync();

        return NoContent();
    }
}
