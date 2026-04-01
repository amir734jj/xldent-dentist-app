namespace Data.Models;

internal partial class Implantecm
{
    public uint Pac { get; set; }

    public uint NumImplante { get; set; }

    public string Dnt { get; set; } = null!;

    public DateTime Dia { get; set; }

    public string? CicatrizaObs { get; set; }

    public string? Bolsas { get; set; }

    public uint? Estabilidade { get; set; }

    public string? HigLimpezaObs { get; set; }

    public uint OfficeId { get; set; }
}
