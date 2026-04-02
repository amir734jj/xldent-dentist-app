using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Agent.Connection;

namespace Agent;

public sealed class AgentWorker(
    AgentConfig config,
    IServiceProvider services,
    ILogger<AgentWorker> logger) : BackgroundService
{
    private static readonly TimeSpan RetryDelay = TimeSpan.FromSeconds(30);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await using var agent = new AgentConnection(config.HubUrl, config.AgentId, config.ApiKey, services);
                await agent.StartAsync(stoppingToken);
                logger.LogInformation("Agent running as '{AgentId}' → {HubUrl}", config.AgentId, config.HubUrl);
                await Task.Delay(Timeout.Infinite, stoppingToken);
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {
                break;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Agent connection failed. Retrying in {Delay}s", RetryDelay.TotalSeconds);
                await Task.Delay(RetryDelay, stoppingToken);
            }
        }

        logger.LogInformation("Agent stopped");
    }
}
