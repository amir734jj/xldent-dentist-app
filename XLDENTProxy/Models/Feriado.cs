namespace XLDENTProxy.Models;

internal partial class Feriado
{
    public DateTime Dia { get; set; }

    public string Feriado1 { get; set; } = null!;

    public string Anual { get; set; } = null!;

    public uint OfficeId { get; set; }
}
