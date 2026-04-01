namespace Data.Models;

internal partial class Benplancat
{
    public uint CatSeq { get; set; }

    public uint PlanId { get; set; }

    public string Category { get; set; } = null!;

    public string? FromRange { get; set; }

    public string? ThruRange { get; set; }

    public byte? Percent { get; set; }

    public string? Deductible { get; set; }

    public uint OfficeId { get; set; }
}
