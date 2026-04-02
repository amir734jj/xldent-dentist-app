namespace XLDENTProxy.Models;

internal partial class Claimtxn
{
    public uint ClaimTxnId { get; set; }

    public uint ClaimId { get; set; }

    public uint PatientNo { get; set; }

    public byte ClaimStatus { get; set; }

    public uint? InsuranceId { get; set; }

    public byte? InsSeq { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastSubmitDate { get; set; }

    public decimal? SubmitValue { get; set; }

    public decimal? EstValue { get; set; }

    public decimal OtheInsValue { get; set; }

    public uint TratLink { get; set; }

    public uint? DiagIndex { get; set; }

    public byte Quantity { get; set; }

    public DateTime Tdate { get; set; }

    public decimal Value { get; set; }

    public decimal ValueEnt { get; set; }

    public string Tooth { get; set; } = null!;

    public uint? Surface { get; set; }

    public uint OfficeId { get; set; }
}
