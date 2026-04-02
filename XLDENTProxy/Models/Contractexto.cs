namespace XLDENTProxy.Models;

internal partial class Contractexto
{
    public uint AuxAutoExt { get; set; }

    public uint? ContractId { get; set; }

    public uint? ContractKind { get; set; }

    public uint? Pac { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? CycleAmount { get; set; }

    public string? Trat { get; set; }

    public int? ProviderId { get; set; }

    public int? ClaimId { get; set; }

    public decimal? PaidAmount { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime? BilledDate { get; set; }

    public string? Billed { get; set; }

    public uint? AuxAutoTrt { get; set; }

    public uint OfficeId { get; set; }
}
