namespace Data.Models;

internal partial class Orclivre
{
    public uint Pac { get; set; }

    public uint? Norc { get; set; }

    public DateTime Dia { get; set; }

    public decimal Valor { get; set; }

    public string Aprovado { get; set; } = null!;

    public byte[]? Texto { get; set; }

    public byte[]? Obs { get; set; }

    public uint OfficeId { get; set; }
}
