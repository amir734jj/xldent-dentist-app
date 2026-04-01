namespace Data.Models;

internal partial class Stmttrt
{
    public uint TrtId { get; set; }

    public uint StatementId { get; set; }

    public uint RespParty { get; set; }

    public uint Pac { get; set; }

    public byte ClaimStatus { get; set; }

    public string? ToPrimary { get; set; }

    public string? ToSecondary { get; set; }

    public uint? InsuranceId { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastSubmitDate { get; set; }

    public decimal? EstValue { get; set; }

    public uint TratLink { get; set; }

    public DateTime? Tdate { get; set; }

    public TimeSpan Ttime { get; set; }

    public string Trat { get; set; } = null!;

    public string TrtDesc { get; set; } = null!;

    public decimal ValuePac { get; set; }

    public decimal ValueEnt { get; set; }

    public string? Tooth { get; set; }

    public uint? Surface { get; set; }

    public uint? ProviderId { get; set; }

    public string? ClaimId { get; set; }

    public uint OfficeId { get; set; }
}
