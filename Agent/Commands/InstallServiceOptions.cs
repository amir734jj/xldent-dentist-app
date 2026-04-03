using CommandLine;

namespace Agent.Commands;

[Verb("install-service", HelpText = "Install as a Windows/systemd service.")]
internal class InstallServiceOptions;