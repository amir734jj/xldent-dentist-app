namespace Data.Models;

internal partial class Urgencia
{
    public uint? Medico { get; set; }

    public DateTime Dia { get; set; }

    public TimeSpan Hora { get; set; }

    public byte Prioridade { get; set; }

    public uint Mecano { get; set; }

    public string Urgencia1 { get; set; } = null!;

    public uint OfficeId { get; set; }
}
