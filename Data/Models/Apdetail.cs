namespace Data.Models;

internal partial class Apdetail
{
    public string EventId { get; set; } = null!;

    public uint? Account { get; set; }

    public uint? RespParty { get; set; }

    public DateTime? StartDate { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public string? Duration { get; set; }

    public uint? CategoryId { get; set; }

    public byte? EventType { get; set; }

    public uint? ProviderId { get; set; }

    public string? Notes { get; set; }

    public uint? NumGeral { get; set; }

    public uint? NumOrc { get; set; }

    public uint? ClaimId { get; set; }

    public uint LabCaseId { get; set; }

    public uint OfficeId { get; set; }
}
