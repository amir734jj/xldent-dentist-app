namespace Data.Models;

internal partial class Tratpay
{
    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public TimeSpan Time { get; set; }

    public string Inicial { get; set; } = null!;

    public uint AuxAuto { get; set; }

    public uint? LastTrtAuxAuto { get; set; }

    public uint? Clinico { get; set; }

    public string Guia { get; set; } = null!;

    public sbyte SitFac { get; set; }

    public decimal ValuePay { get; set; }

    public string? AltDesc { get; set; }

    public string? CctransId { get; set; }

    public string? CcrefId { get; set; }

    public string? Ccard { get; set; }

    public uint? MasterLink { get; set; }

    public uint? ClaimId { get; set; }

    public string? InsSeq { get; set; }

    public uint? CreatedBy { get; set; }

    public string? TransType { get; set; }

    public int OfficePaid { get; set; }

    public uint OfficeId { get; set; }
}
