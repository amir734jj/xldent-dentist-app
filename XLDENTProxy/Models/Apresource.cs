namespace XLDENTProxy.Models;

internal partial class Apresource
{
    public int ResourceId { get; set; }

    public string Caption { get; set; } = null!;

    public int? TitleColor { get; set; }

    public short? ImageIndex { get; set; }

    public TimeSpan? DayBegins { get; set; }

    public TimeSpan? DayEnds { get; set; }

    public int? DayHrsColor { get; set; }

    public int? OffHrsColor { get; set; }

    public byte? ConflictingAppt { get; set; }

    public byte? ApptBufferTime { get; set; }

    public string? TimeBlocks { get; set; }

    public uint? ProviderId { get; set; }

    public uint OfficeId { get; set; }
}
