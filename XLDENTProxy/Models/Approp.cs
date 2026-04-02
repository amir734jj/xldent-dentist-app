namespace XLDENTProxy.Models;

internal partial class Approp
{
    public byte? PropertySeq { get; set; }

    public byte? MinInterval { get; set; }

    public TimeSpan? DayBegins { get; set; }

    public TimeSpan? DayEnds { get; set; }

    public byte? RowHeight { get; set; }

    public byte? HideOffHrs { get; set; }

    public byte? EventHint { get; set; }

    public byte? VisibleResources { get; set; }

    public byte? StartAtCurrentTime { get; set; }

    public int? OffHrsColor { get; set; }

    public bool? ShowAllTimeBars { get; set; }

    public bool? ShowResourceDate { get; set; }

    public bool? ShowHeader { get; set; }

    public bool? ShowStatusBar { get; set; }

    public bool? AlphaBlending { get; set; }

    public byte? AlphaBlendValue { get; set; }

    public bool? GradientFill { get; set; }

    public bool? ApptShadow { get; set; }

    public byte? CompressWeekEnds { get; set; }

    public byte? ConflictingAppt { get; set; }

    public byte? CalendarMonths { get; set; }

    public byte? CalendarMonthsD { get; set; }

    public byte? ResourceTask { get; set; }

    public bool? ShowTimeBlockText { get; set; }

    public byte? WeekendColorNoChange { get; set; }

    public string? NetRefresh { get; set; }

    public uint OfficeId { get; set; }
}
