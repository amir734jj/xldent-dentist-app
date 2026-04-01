namespace Data.Models;

internal partial class Labcase
{
    public uint CaseId { get; set; }

    public uint LabId { get; set; }

    public uint LabCategoryId { get; set; }

    public int Pac { get; set; }

    public uint ProviderId { get; set; }

    public uint CreatedById { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Tooth { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime SentDate { get; set; }

    public DateTime CaseDue { get; set; }

    public DateTime ReceivedDate { get; set; }

    public DateTime ClosedDate { get; set; }

    public string Notes { get; set; } = null!;

    public uint OfficeId { get; set; }
}
