namespace Data.Models;

internal partial class Contractshdr
{
    public uint ContractId { get; set; }

    public uint? Pac { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime? OrthoDate { get; set; }

    public int? OrthoMonths { get; set; }

    public string? Notes { get; set; }

    public uint OfficeId { get; set; }
}
