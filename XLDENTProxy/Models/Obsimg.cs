namespace XLDENTProxy.Models;

internal partial class Obsimg
{
    public uint Mecano { get; set; }

    public string Dente { get; set; } = null!;

    public string NomeFichImg { get; set; } = null!;

    public int? FactorPixels { get; set; }

    public double? FactorCm { get; set; }

    public string? Obs { get; set; }

    public uint OfficeId { get; set; }
}
