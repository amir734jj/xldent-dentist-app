namespace XLDENTProxy.Models;

internal partial class Fobratrt
{
    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public TimeSpan Hora { get; set; }

    public string Inicial { get; set; } = null!;

    public byte Face { get; set; }

    public uint Entidade { get; set; }

    public string? Guia { get; set; }

    public string Dente { get; set; } = null!;

    public byte SitFac { get; set; }

    public uint Medico { get; set; }

    public int Fobra { get; set; }

    public uint? Especialidade { get; set; }

    public uint AuxAuto { get; set; }

    public uint OfficeId { get; set; }
}
