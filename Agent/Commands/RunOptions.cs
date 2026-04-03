using CommandLine;

namespace Agent.Commands;

[Verb("run", isDefault: true, HelpText = "Run the agent (default).")]
internal class RunOptions;