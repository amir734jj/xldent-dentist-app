namespace XLDENTProxy.Models;

internal partial class Benplanext
{
    public uint PlanSeq { get; set; }

    public uint PlanId { get; set; }

    public string Code { get; set; } = null!;

    public string? Deductible { get; set; }

    public decimal? AllowedAmount { get; set; }

    public byte? Percent { get; set; }

    public uint OfficeId { get; set; }
}
