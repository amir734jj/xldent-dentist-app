using Api.Hubs;
using Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Shared.Contracts;
using Shared.Messages.Interfaces;
using Shared.Messages.Requests;
using Shared.Messages.Responses;

namespace Api.Controllers;

[ApiController]
[Route("api/agents")]
[Authorize]
public sealed class AgentsController(AgentRegistry registry, IHubContext<AgentHub> hub) : ControllerBase
{
    [HttpGet]
    public IActionResult List()
    {
        return Ok(registry.ConnectedAgents());
    }

    [HttpGet("{agentId}/health")]
    public async Task<IActionResult> Health(string agentId, CancellationToken ct)
    {
        var cid = registry.GetConnectionId(agentId);
        if (cid is null)
        {
            return Ok(new AgentHealthResponse(agentId, AgentStatus.Offline, null, false));
        }

        try
        {
            using var timeout = CancellationTokenSource.CreateLinkedTokenSource(ct);
            timeout.CancelAfter(TimeSpan.FromSeconds(10));
            var response = await hub.Clients.Client(cid)
                .InvokeAsync<IAgentResponse>("Proxy", new GetHealthRequest(), timeout.Token);

            if (response is HealthResponse health)
            {
                var status = health.DbConnected ? AgentStatus.Online : AgentStatus.Degraded;
                return Ok(new AgentHealthResponse(agentId, status, health.CheckedAt, health.DbConnected));
            }
        }
        catch (Exception)
        {
            // agent unreachable — fall through to offline
        }

        return Ok(new AgentHealthResponse(agentId, AgentStatus.Offline, null, false));
    }

    [HttpPost("{agentId}/search")]
    public async Task<IActionResult> Search(string agentId, [FromBody] SearchAppointmentsRequest req, CancellationToken ct)
    {
        var cid = registry.GetConnectionId(agentId);
        if (cid is null)
        {
            return NotFound("Agent not connected.");
        }

        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(ct);
        timeout.CancelAfter(TimeSpan.FromSeconds(30));
        try
        {
            var response = await hub.Clients.Client(cid)
                .InvokeAsync<IAgentResponse>("Proxy", req, timeout.Token);
            return response switch
            {
                AppointmentsResponse r => Content(r.Data, "application/json"),
                AgentErrorResponse e   => StatusCode(502, e.Message),
                _                      => StatusCode(502, "Unexpected response from agent.")
            };
        }
        catch (OperationCanceledException)
        {
            return StatusCode(504, "Agent timed out.");
        }
    }

    [HttpPost("{agentId}/cancel-appointment")]
    public async Task<IActionResult> CancelAppointment(
        string agentId,
        [FromBody] Shared.Contracts.CancelAppointmentRequest req,
        CancellationToken ct)
    {
        var cid = registry.GetConnectionId(agentId);
        if (cid is null)
        {
            return NotFound("Agent not connected.");
        }

        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(ct);
        timeout.CancelAfter(TimeSpan.FromSeconds(30));
        try
        {
            var response = await hub.Clients.Client(cid)
                .InvokeAsync<IAgentResponse>("Proxy",
                    new Shared.Messages.Requests.CancelAppointmentRequest { EventId = req.EventId },
                    timeout.Token);
            return response switch
            {
                SuccessResponse r    => Ok(new { r.Value }),
                AgentErrorResponse e => StatusCode(502, e.Message),
                _                   => StatusCode(502, "Unexpected response from agent.")
            };
        }
        catch (OperationCanceledException)
        {
            return StatusCode(504, "Agent timed out.");
        }
    }
}
