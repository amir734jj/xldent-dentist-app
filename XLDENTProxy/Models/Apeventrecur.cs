namespace XLDENTProxy.Models;

internal partial class Apeventrecur
{
    public string RecurrenceId { get; set; } = null!;

    public short? RRule { get; set; }

    public short? RRuleType { get; set; }

    public short? RInterval { get; set; }

    public string? RModifier { get; set; }

    public DateTime? RStartDate { get; set; }

    public DateTime? REndDate { get; set; }

    public short? RDuration { get; set; }

    public string? ROccurSpecifier { get; set; }

    public short? RStartOfWeek { get; set; }

    public short? RRecurEndType { get; set; }

    public short? RWeekEndMove { get; set; }

    public string? RExceptDates { get; set; }

    public string EventId { get; set; } = null!;

    public short ResourceId { get; set; }

    public string? Subject { get; set; }

    public string? Location { get; set; }

    public DateTime? StartDate { get; set; }

    public TimeSpan? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public TimeSpan? EndTime { get; set; }

    public DateTime? DueDate { get; set; }

    public bool? Private { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? OwnedBy { get; set; }

    public sbyte? PercentComplete { get; set; }

    public string? Status { get; set; }

    public string? EventTypeName { get; set; }

    public string? Contact { get; set; }

    public int? BackColor { get; set; }

    public string? FontName { get; set; }

    public uint? FontColor { get; set; }

    public string? FontStyle { get; set; }

    public short? FontSize { get; set; }

    public string? Priority { get; set; }

    public string? Notes { get; set; }

    public int? IconIndex { get; set; }

    public int EventKind { get; set; }

    public string? AlarmFileName { get; set; }

    public bool? AlarmSet { get; set; }

    public bool? Done { get; set; }

    public string? AlarmMsg { get; set; }

    public short? AlarmLeadIndex { get; set; }

    public bool? Reminder { get; set; }

    public TimeSpan? ReminderTime { get; set; }

    public DateTime? ReminderDate { get; set; }

    public string? ShowTimeAs { get; set; }

    public string? Category { get; set; }

    public uint? CategoryId { get; set; }

    public bool? AllDay { get; set; }

    public string? ExceptionFields { get; set; }

    public string? ShareId { get; set; }

    public string? Attachments { get; set; }

    public string? EventCode { get; set; }

    public bool? NoOverLap { get; set; }

    public byte? Visible { get; set; }

    public byte? ReadOnly { get; set; }

    public byte? EventType { get; set; }

    public byte? CategoryIndex { get; set; }

    public byte[]? IconImage { get; set; }

    public uint OfficeId { get; set; }
}
