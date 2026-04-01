namespace Data.Models;

internal partial class Salasocp
{
    public DateTime Dia { get; set; }

    public TimeSpan Hora { get; set; }

    public uint? Medico { get; set; }

    public uint Pac { get; set; }

    public uint? Sala { get; set; }

    public uint OfficeId { get; set; }
}
