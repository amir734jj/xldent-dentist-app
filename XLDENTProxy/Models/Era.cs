namespace XLDENTProxy.Models;

internal partial class Era
{
    public uint EraAuxAuto { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public string? EraText { get; set; }

    /// <summary>
    /// For Orphan Payements
    /// </summary>
    public string? EraCheckNo { get; set; }

    /// <summary>
    /// For Orphan Payements
    /// </summary>
    public uint? Eralink { get; set; }

    /// <summary>
    /// For Orphan Payements
    /// </summary>
    public decimal? ErapayAmount { get; set; }

    public uint OfficeId { get; set; }
}
