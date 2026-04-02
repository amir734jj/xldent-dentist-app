using Spectre.Console;

namespace Service.Connection;

public static class ConnectionSetup
{
    public static ConnectionProfile Prompt(ConnectionProfile? saved)
    {
        AnsiConsole.Write(new Rule("[bold blue]XLDent — MySQL Connection[/]").RuleStyle("grey"));
        AnsiConsole.MarkupLine($"[grey]DB path: {ConnectionStore.DbPath}[/]");
        AnsiConsole.WriteLine();

        if (saved is not null)
        {
            AnsiConsole.Write(new Panel(
                    $"[green]{saved.Server}[/]:[yellow]{saved.Port}[/]/[blue]{saved.Database}[/]  " +
                    $"user [yellow]{saved.Username}[/]  " +
                    $"[grey]{saved.LastUsed.ToLocalTime():yyyy-MM-dd HH:mm}[/]")
                .Header("[grey]Last used[/]")
                .BorderColor(Color.Grey));

            AnsiConsole.WriteLine();

            if (AnsiConsole.Confirm("Use this connection?", defaultValue: true))
            {
                return saved;
            }

            AnsiConsole.WriteLine();
        }

        var server = AnsiConsole.Prompt(
            new TextPrompt<string>("[green]Server / IP[/]:")
                .DefaultValue(saved?.Server ?? "127.0.0.1")
                .PromptStyle("yellow"));

        var port = AnsiConsole.Prompt(
            new TextPrompt<int>("[green]Port[/]:")
                .DefaultValue(saved?.Port ?? 3306)
                .PromptStyle("yellow")
                .ValidationErrorMessage("[red]Must be a number between 1 and 65535[/]")
                .Validate(p => p is >= 1 and <= 65535
                    ? ValidationResult.Success()
                    : ValidationResult.Error()));

        var database = AnsiConsole.Prompt(
            new TextPrompt<string>("[green]Database[/]:")
                .DefaultValue(saved?.Database ?? "DRDATA")
                .PromptStyle("yellow"));

        var username = AnsiConsole.Prompt(
            new TextPrompt<string>("[green]Username[/]:")
                .DefaultValue(saved?.Username ?? "root")
                .PromptStyle("yellow"));

        var password = AnsiConsole.Prompt(
            new TextPrompt<string>("[green]Password[/]:")
                .Secret()
                .AllowEmpty()
                .PromptStyle("yellow"));

        AnsiConsole.WriteLine();
        AnsiConsole.Write(new Rule().RuleStyle("grey"));
        AnsiConsole.WriteLine();

        return new ConnectionProfile
        {
            Server   = server,
            Port     = port,
            Database = database,
            Username = username,
            Password = password
        };
    }
}
