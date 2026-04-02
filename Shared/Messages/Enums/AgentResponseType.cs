using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shared.Messages.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum AgentResponseType
{
    Health,
    Appointments,
    Success,
    Error,
}
