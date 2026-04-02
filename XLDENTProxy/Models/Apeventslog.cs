namespace XLDENTProxy.Models;

internal partial class Apeventslog
{
    public uint EventId { get; set; }

    public string DeletedId { get; set; } = null!;

    public string UpdatedId { get; set; } = null!;

    public short ResourceId { get; set; }

    public string? Subject { get; set; }

    public DateTime? StartDate { get; set; }

    public TimeSpan? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public TimeSpan? EndTime { get; set; }

    public DateTime? DueDate { get; set; }

    public string? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public string? EventTypeName { get; set; }

    public int EventKind { get; set; }

    public string? EventCode { get; set; }

    public string? Details { get; set; }

    public uint DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? RecallFlag { get; set; }

    public DateTime? ChangedOn { get; set; }

    public uint OfficeId { get; set; }
}
