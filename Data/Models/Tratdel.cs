namespace Data.Models;

internal partial class Tratdel
{
    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public TimeSpan Time { get; set; }

    public string Inicial { get; set; } = null!;

    public sbyte Face { get; set; }

    public uint AuxAuto { get; set; }

    public short CdX { get; set; }

    public short CdY { get; set; }

    public string Especial { get; set; } = null!;

    public short Entidade { get; set; }

    public string Guia { get; set; } = null!;

    public string Dente { get; set; } = null!;

    public sbyte SitFac { get; set; }

    public uint? Clinico { get; set; }

    public uint? CorMaterial { get; set; }

    public decimal? ValuePac { get; set; }

    public decimal? ValueEnt { get; set; }

    public decimal? ValueChanged { get; set; }

    public decimal? ValueChangedGlobal { get; set; }

    public decimal? ValuePaid { get; set; }

    public decimal? TaxValue { get; set; }

    public string? Tstatus { get; set; }

    public uint LastTrtAuxAuto { get; set; }

    public decimal ValuePay { get; set; }

    public DateTime? DeleteWhen { get; set; }

    public string? TrtKind { get; set; }

    public uint? DeleteUser { get; set; }

    public uint DelSeq { get; set; }

    public string? CctransId { get; set; }

    public uint OfficeId { get; set; }
}
