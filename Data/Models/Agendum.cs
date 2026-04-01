namespace Data.Models;

internal partial class Agendum
{
    public uint? Medico { get; set; }

    public DateTime Dia { get; set; }

    public TimeSpan Hora { get; set; }

    public string Conf { get; set; } = null!;

    public string? Marcacao { get; set; }

    public uint Mecano { get; set; }

    public uint? Entidade { get; set; }

    public uint? Operador { get; set; }

    public DateTime? DiaMarcacao { get; set; }

    public string? Obs { get; set; }

    public uint OfficeId { get; set; }
}
