namespace XLDENTProxy.Models;

internal partial class Fobra
{
    public uint Fpac { get; set; }

    public int Fobra1 { get; set; }

    public short Ftipo { get; set; }

    public DateTime Fdia { get; set; }

    public string Fref { get; set; } = null!;

    public string? Fdesc { get; set; }

    public string? Fmarca { get; set; }

    public short? Fquant { get; set; }

    public short? FoperEnt { get; set; }

    public short? FoperDev { get; set; }

    public short? Fdev { get; set; }

    public decimal? Fpreco { get; set; }

    public decimal? Fiva { get; set; }

    public string? Flaboratorio { get; set; }

    public int Fclinico { get; set; }

    public uint OfficeId { get; set; }
}
