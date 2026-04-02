namespace XLDENTProxy.Models;

internal partial class Protlab
{
    public string CodProt { get; set; } = null!;

    public int Pac { get; set; }

    public uint? TipoProt { get; set; }

    public uint? Laboratorio { get; set; }

    public DateTime? EnvioLab { get; set; }

    public DateTime? PrevLab { get; set; }

    public DateTime? DiaAplicacao { get; set; }

    public decimal? OrcamLab { get; set; }

    public decimal? OrcamPac { get; set; }

    public string Pago { get; set; } = null!;

    public uint OfficeId { get; set; }
}
