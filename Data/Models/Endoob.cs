namespace Data.Models;

internal partial class Endoob
{
    public uint Pac { get; set; }

    public string Dente { get; set; } = null!;

    public DateTime Dia { get; set; }

    public string LesApical { get; set; } = null!;

    public string MedApical { get; set; } = null!;

    public string? Obs { get; set; }

    public uint OfficeId { get; set; }
}
