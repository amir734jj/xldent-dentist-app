namespace XLDENTProxy.Models;

internal partial class Listaespera
{
    public uint Clinico { get; set; }

    public DateTime Dia { get; set; }

    public uint? Ordem { get; set; }

    public TimeSpan HoraAgenda { get; set; }

    public TimeSpan HoraRegisto { get; set; }

    public string Nome { get; set; } = null!;

    public uint Mecano { get; set; }

    public string? Obs { get; set; }

    public string Urgencia { get; set; } = null!;

    public uint OfficeId { get; set; }
}
