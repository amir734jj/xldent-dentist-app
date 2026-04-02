namespace XLDENTProxy.Models;

internal partial class Contractso
{
    public uint ContractId { get; set; }

    public uint Pac { get; set; }

    public uint ContractKind { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? NextDueDate { get; set; }

    public DateTime? StartDate { get; set; }

    public decimal? ContractAmount { get; set; }

    public decimal? DownPayment { get; set; }

    public decimal? RemainingAmount { get; set; }

    public decimal? CycleAmount { get; set; }

    public decimal? AmountBilled { get; set; }

    public sbyte? MonthsPerCycle { get; set; }

    public uint? NumberOfCycles { get; set; }

    public uint? CompletedCycles { get; set; }

    public uint? ProviderId { get; set; }

    public string? Trat { get; set; }

    public uint OfficeId { get; set; }
}
