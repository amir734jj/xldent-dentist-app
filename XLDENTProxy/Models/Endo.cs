namespace XLDENTProxy.Models;

internal partial class Endo
{
    public uint Pac { get; set; }

    public string InicialTrat { get; set; } = null!;

    public string Dente { get; set; } = null!;

    public DateTime Dia { get; set; }

    public string Raiz { get; set; } = null!;

    public string Valores { get; set; } = null!;

    public uint OfficeId { get; set; }
}
