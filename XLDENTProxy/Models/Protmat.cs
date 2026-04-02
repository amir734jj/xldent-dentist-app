namespace XLDENTProxy.Models;

internal partial class Protmat
{
    public int Pac { get; set; }

    public int CodProt { get; set; }

    public string Dnt { get; set; } = null!;

    public DateTime? Dia { get; set; }

    public string? TipoM { get; set; }

    public short? CorM { get; set; }

    public string? FabRef { get; set; }

    public string? FabNome { get; set; }

    public string? Obs { get; set; }

    public uint OfficeId { get; set; }
}
