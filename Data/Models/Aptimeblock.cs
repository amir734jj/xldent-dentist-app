namespace Data.Models;

internal partial class Aptimeblock
{
    public string TimeBlockId { get; set; } = null!;

    public string? Caption { get; set; }

    public byte? LockIt { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public int? Color { get; set; }

    public byte? AllResources { get; set; }

    public byte? IsActive { get; set; }

    public string? RecurrenceId { get; set; }

    public byte? RecurPattern { get; set; }

    public string? FontName { get; set; }

    public string? FontStyle { get; set; }

    public uint? FontSize { get; set; }

    public int? FontColor { get; set; }

    public uint OfficeId { get; set; }
}
