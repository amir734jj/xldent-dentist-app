using CommandLine;

namespace Agent.Commands;

[Verb("uninstall-service", HelpText = "Uninstall the Windows/systemd service.")]
internal class UninstallServiceOptions;