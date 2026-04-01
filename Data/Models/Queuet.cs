namespace Data.Models;

internal partial class Queuet
{
    public uint QueueId { get; set; }

    public string? ComputerName { get; set; }

    public string? QueueType { get; set; }

    public string? Params { get; set; }

    public uint OfficeId { get; set; }
}
