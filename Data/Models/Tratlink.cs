namespace Data.Models;

internal partial class Tratlink
{
    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public TimeSpan Time { get; set; }

    public string Inicial { get; set; } = null!;

    public uint AuxAuto { get; set; }

    public uint? Doctor { get; set; }

    public uint? TratLink { get; set; }

    public uint? PayLink { get; set; }

    public string? Guia { get; set; }

    public sbyte SitFac { get; set; }

    public decimal? ValuePaid { get; set; }

    public uint OfficeId { get; set; }
}
