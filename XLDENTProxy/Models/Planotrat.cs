namespace XLDENTProxy.Models;

internal partial class Planotrat
{
    public uint NumGeral { get; set; }

    public string? Titulo { get; set; }

    public uint NumOrc { get; set; }

    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public string Dente { get; set; } = null!;

    public uint Entidade { get; set; }

    public uint AuxAuto { get; set; }

    public uint Especialidade { get; set; }

    public uint? Clinico { get; set; }

    public decimal? Valor { get; set; }

    public decimal? ValueEnt1 { get; set; }

    public decimal? ValueEnt2 { get; set; }

    public decimal? ValueChanged { get; set; }

    public string? Situacao { get; set; }

    public string? Aprovado { get; set; }

    public byte? Face { get; set; }

    public string? Guia { get; set; }

    public uint AuxAutoTrt { get; set; }

    public byte? Phase { get; set; }

    public uint? Minutes { get; set; }

    public byte Level { get; set; }

    public uint OfficeId { get; set; }
}
