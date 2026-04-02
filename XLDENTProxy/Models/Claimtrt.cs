namespace XLDENTProxy.Models;

internal partial class Claimtrt
{
    public uint ClaimTrtId { get; set; }

    public uint ClaimId { get; set; }

    public byte? InsSeq { get; set; }

    public uint PatientNo { get; set; }

    public byte ClaimStatus { get; set; }

    public string? ToPrimary { get; set; }

    public string? ToSecondary { get; set; }

    public uint? InsuranceId { get; set; }

    public uint? PlanId { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastSubmitDate { get; set; }

    public decimal? SubmitValue { get; set; }

    public decimal? EstValue { get; set; }

    public decimal OtheInsValue { get; set; }

    public uint TratLink { get; set; }

    public string? Trat { get; set; }

    public string? DiagIndex { get; set; }

    public byte Quantity { get; set; }

    public DateTime? Tdate { get; set; }

    public decimal Value { get; set; }

    public decimal ValueEnt { get; set; }

    public string Tooth { get; set; } = null!;

    public uint? Surface { get; set; }

    public uint? NumOrc { get; set; }

    public uint NumGeral { get; set; }

    public string? Emg { get; set; }

    public string? Modifier { get; set; }

    public string? Units { get; set; }

    public string? AddSuplInfo { get; set; }

    public string? AddEpsdt1 { get; set; }

    public string? AddEpsdt2 { get; set; }

    public uint OfficeId { get; set; }
}
