namespace Data.Models;

internal partial class Apblockrecur
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

    public string? RActiveDates { get; set; }

    public uint OfficeId { get; set; }
}
