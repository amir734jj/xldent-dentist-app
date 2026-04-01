namespace Data.Models;

internal partial class Endositu
{
    public uint Pac { get; set; }

    public string InicialTrat { get; set; } = null!;

    public string Dente { get; set; } = null!;

    public byte Situacao { get; set; }

    public byte Canais { get; set; }

    public byte Sessoes { get; set; }

    public uint OfficeId { get; set; }
}
