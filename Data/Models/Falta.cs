namespace Data.Models;

internal partial class Falta
{
    public uint? Medico { get; set; }

    public uint Mecano { get; set; }

    public DateTime Dia { get; set; }

    public TimeSpan Hora { get; set; }

    public string FaltaCancela { get; set; } = null!;

    public string Marcacao { get; set; } = null!;

    public string Obs { get; set; } = null!;

    public uint OfficeId { get; set; }
}
