namespace Data.Models;

internal partial class Agdmotivo
{
    public uint? Medico { get; set; }

    public uint Mecano { get; set; }

    public DateTime DiaReg { get; set; }

    public string Atribuido { get; set; } = null!;

    public string? Motivo { get; set; }

    public DateTime DiaMarca { get; set; }

    public TimeSpan HoraMarca { get; set; }

    public uint OfficeId { get; set; }
}
