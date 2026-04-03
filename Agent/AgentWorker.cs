using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Agent.Connection;
using Polly;
using Polly.Retry;

namespace Agent;

public sealed class AgentWorker(
    AgentConfig config,
    IServiceProvider services,
    ILogger<AgentWorker> logger) : BackgroundService
{
    private static readonly TimeSpan RetryDelay = TimeSpan.FromSeconds(30);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var pipeline = new ResiliencePipelineBuilder()
            .AddRetry(new RetryStrategyOptions
            {
                MaxRetryAttempts = int.MaxValue,
                Delay = RetryDelay,
                BackoffType = DelayBackoffType.Constant,
                ShouldHandle = new PredicateBuilder().Handle<Exception>(ex => ex is not OperationCanceledException),
                OnRetry = args =>
                {
                    logger.LogWarning(
                        "Agent connection attempt {Attempt} failed ({Message}). Retrying in {Delay}s…",
                        args.AttemptNumber + 1,
                        args.Outcome.Exception?.Message,
                        RetryDelay.TotalSeconds);
                    return ValueTask.CompletedTask;
                }
            })
            .Build();

        try
        {
            await pipeline.ExecuteAsync(async ct =>
            {
                await using var agent = new AgentConnection(config.ServerUrl, config.AgentId, config.ApiKey, services);
                await agent.StartAsync(ct);
                logger.LogInformation("Agent running as '{AgentId}' → {ServerUrl}", config.AgentId, config.ServerUrl);
                await Task.Delay(Timeout.Infinite, ct);
            }, stoppingToken);
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested) { }

        logger.LogInformation("Agent stopped");
    }
}
