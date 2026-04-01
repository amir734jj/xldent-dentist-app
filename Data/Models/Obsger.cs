namespace Data.Models;

internal partial class Obsger
{
    public uint AuxAutoObsGer { get; set; }

    public uint Pac { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime Dia { get; set; }

    public string Dente { get; set; } = null!;

    public uint AuxAutoTrt { get; set; }

    public string Vista { get; set; } = null!;

    public string? Obs { get; set; }

    public uint OfficeId { get; set; }
}
