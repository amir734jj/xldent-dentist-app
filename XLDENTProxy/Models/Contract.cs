namespace XLDENTProxy.Models;

internal partial class Contract
{
    public uint ContractId { get; set; }

    public uint? Pac { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? NextDueDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? DownPayment { get; set; }

    public decimal? RemainingAmount { get; set; }

    public decimal? CycleAmount { get; set; }

    public decimal? AmountBilled { get; set; }

    public sbyte? Cycle { get; set; }

    public uint? NumberOfCycles { get; set; }

    public uint? CompletedCycles { get; set; }

    public int? ProviderId { get; set; }

    public string? Trat { get; set; }

    public uint OfficeId { get; set; }
}
