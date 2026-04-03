using Agent.Constants;
using Spectre.Console;

namespace Agent.Connection;

public static class AgentSetup
{
    public static AgentConfig Prompt(AgentConfig? saved)
    {
        AnsiConsole.Write(new Rule("[bold blue]XLDent — Agent Connection[/]").RuleStyle("grey"));
        AnsiConsole.WriteLine();

        if (saved is not null && !string.IsNullOrEmpty(saved.ServerUrl))
        {
            AnsiConsole.Write(new Panel(
                    $"[green]{saved.ServerUrl}[/]\n" +
                    $"Agent ID [yellow]{saved.AgentId}[/]  " +
                    $"API Key [grey]{MaskKey(saved.ApiKey)}[/]")
                .Header("[grey]Saved config[/]")
                .BorderColor(Color.Grey));

            AnsiConsole.WriteLine();

            if (AnsiConsole.Confirm("Use this agent config?", defaultValue: true))
            {
                return saved;
            }

            AnsiConsole.WriteLine();
        }

        var serverUrl = AnsiConsole.Prompt(
            new TextPrompt<string>("[green]Server URL[/] (e.g. https://xldent-....herokuapp.com):")
                .DefaultValue(!string.IsNullOrEmpty(saved?.ServerUrl) ? saved!.ServerUrl : AgentConstants.DefaultServerUrl)
                .PromptStyle("yellow"));

        var agentId = AnsiConsole.Prompt(
            new TextPrompt<string>("[green]Agent ID[/]:")
                .DefaultValue(!string.IsNullOrEmpty(saved?.AgentId) ? saved!.AgentId : AgentConstants.DefaultAgentId)
                .PromptStyle("yellow"));

        var apiKey = AnsiConsole.Prompt(
            new TextPrompt<string>("[green]API Key[/]:")
                .Secret()
                .PromptStyle("yellow")
                .Validate(k => !string.IsNullOrWhiteSpace(k)
                    ? ValidationResult.Success()
                    : ValidationResult.Error("[red]API Key is required[/]")));

        AnsiConsole.WriteLine();
        AnsiConsole.Write(new Rule().RuleStyle("grey"));
        AnsiConsole.WriteLine();

        return new AgentConfig
        {
            ServerUrl = serverUrl.TrimEnd('/'),
            AgentId   = agentId,
            ApiKey    = apiKey
        };
    }

    private static string MaskKey(string key)
    {
        return key.Length <= 8 ? new string('*', key.Length) : key[..4] + new string('*', key.Length - 4);
    }
}
