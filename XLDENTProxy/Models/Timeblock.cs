namespace XLDENTProxy.Models;

internal partial class Timeblock
{
    public string TimeBlockId { get; set; } = null!;

    public string? Caption { get; set; }

    public byte? LockIt { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public uint? Color { get; set; }

    public byte? AllResources { get; set; }

    public byte? IsActive { get; set; }

    public string? RecurrenceId { get; set; }

    public byte? RecurPattern { get; set; }

    public string? FontStyle { get; set; }

    public uint? FontSize { get; set; }

    public uint? FontColor { get; set; }

    public uint OfficeId { get; set; }
}
