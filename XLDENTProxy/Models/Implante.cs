namespace XLDENTProxy.Models;

internal partial class Implante
{
    public uint Pac { get; set; }

    public string Dnt { get; set; } = null!;

    public uint CodImpl { get; set; }

    public uint? TipoImpl { get; set; }

    public uint? RegOssea { get; set; }

    public short? Altura { get; set; }

    public short? Largura { get; set; }

    public short? EstrutOssea { get; set; }

    public string? MatCoroa { get; set; }

    public short? CorCoroa { get; set; }

    public short? Angulacao { get; set; }

    public string? Obs { get; set; }

    public uint OfficeId { get; set; }
}
