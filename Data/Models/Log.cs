namespace Data.Models;

internal partial class Log
{
    public uint LogSeq { get; set; }

    public DateTime? LogDate { get; set; }

    public TimeSpan? LogTime { get; set; }

    public uint? UserId { get; set; }

    public string? RecordLink { get; set; }

    public string? Location { get; set; }

    public string? LogText { get; set; }

    public uint OfficeId { get; set; }
}
