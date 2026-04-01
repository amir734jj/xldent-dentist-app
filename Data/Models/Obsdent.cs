namespace Data.Models;

internal partial class Obsdent
{
    public uint Odauxauto { get; set; }

    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Dnt { get; set; } = null!;

    public string Warning { get; set; } = null!;

    public string? Obs { get; set; }

    public uint? AuxAutoTrt { get; set; }

    public uint OfficeId { get; set; }
}
