namespace XLDENTProxy.Models;

internal partial class Agdconf
{
    public uint? Medico { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Fim { get; set; }

    public byte DiaSemana { get; set; }

    public TimeSpan Minicio { get; set; }

    public TimeSpan Mfim { get; set; }

    public byte Mmin { get; set; }

    public TimeSpan Tinicio { get; set; }

    public TimeSpan Tfim { get; set; }

    public byte Tmin { get; set; }

    public string? Obs { get; set; }

    public string VerObs { get; set; } = null!;

    public uint OfficeId { get; set; }
}
