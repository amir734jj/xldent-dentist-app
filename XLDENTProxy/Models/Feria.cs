namespace XLDENTProxy.Models;

internal partial class Feria
{
    public uint? Medico { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Fim { get; set; }

    public string Obs { get; set; } = null!;

    public uint OfficeId { get; set; }
}
