namespace XLDENTProxy.Models;

internal partial class Recurrencedef
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

    public string? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public string? EndTime { get; set; }

    public DateTime? DueDate { get; set; }

    public bool? Private { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? OwnedBy { get; set; }

    public double? PercentComplete { get; set; }

    public string? Status { get; set; }

    public string? EventTypeName { get; set; }

    public string? Contact { get; set; }

    public double? BackColor { get; set; }

    public double? FontColor { get; set; }

    public string? FontStyle { get; set; }

    public short? FontSize { get; set; }

    public string? Priority { get; set; }

    public string? Notes { get; set; }

    public double? IconIndex { get; set; }

    public double? EventKind { get; set; }

    public string? AlarmFileName { get; set; }

    public bool? AlarmSet { get; set; }

    public bool? Done { get; set; }

    public string? AlarmMsg { get; set; }

    public double? AlarmLeadIndex { get; set; }

    public bool? Reminder { get; set; }

    public string? ReminderTime { get; set; }

    public string? ReminderDate { get; set; }

    public string? ShowTimeAs { get; set; }

    public string? Category { get; set; }

    public bool? AllDay { get; set; }

    public bool? ReadOnly { get; set; }

    public string? ExceptionFields { get; set; }

    public string ShareId { get; set; } = null!;

    public string? Attachments { get; set; }

    public uint OfficeId { get; set; }
}
