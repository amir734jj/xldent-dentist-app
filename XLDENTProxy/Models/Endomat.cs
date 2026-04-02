namespace XLDENTProxy.Models;

internal partial class Endomat
{
    public uint Pac { get; set; }

    public string Dente { get; set; } = null!;

    public DateTime Dia { get; set; }

    public string CodMat { get; set; } = null!;

    public string Provisorio { get; set; } = null!;

    public uint OfficeId { get; set; }
}
