namespace Data.Models;

internal partial class Ccorrente
{
    public uint TipDoc { get; set; }

    public uint Terc { get; set; }

    public uint DocPri { get; set; }

    public string Anulado { get; set; } = null!;

    public uint? TipPag { get; set; }

    public uint? TipoNovo { get; set; }

    public uint DocNovo { get; set; }

    public DateTime Dia { get; set; }

    public string? Dccaixa { get; set; }

    public string MovCaixa { get; set; } = null!;

    public decimal Valor { get; set; }

    public decimal ValorPago { get; set; }

    public sbyte PrcDesc { get; set; }

    public uint? RelacionaTipo { get; set; }

    public int RelacionaDoc { get; set; }

    public uint? TipoOld { get; set; }

    public uint DocOld { get; set; }

    public uint OfficeId { get; set; }
}
