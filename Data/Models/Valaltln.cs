namespace Data.Models;

internal partial class Valaltln
{
    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public TimeSpan Time { get; set; }

    public string Inicial { get; set; } = null!;

    public byte Face { get; set; }

    public uint AuxAuto { get; set; }

    public decimal NovoValor { get; set; }

    public decimal ValorGlobal { get; set; }

    public uint OfficeId { get; set; }
}
