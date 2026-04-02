namespace XLDENTProxy.Models;

internal partial class Tcevent
{
    public uint ClockEventId { get; set; }

    public uint? UserId { get; set; }

    public DateTime? ClockInTime { get; set; }

    public DateTime? ClockOutTime { get; set; }

    public string TimeCategory { get; set; } = null!;

    public uint OfficeId { get; set; }
}
