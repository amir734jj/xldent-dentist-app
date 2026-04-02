namespace XLDENTProxy.Models;

internal partial class Processostrat
{
    public uint? Especialidade { get; set; }

    public uint Mecano { get; set; }

    public int SitFac { get; set; }

    public uint Processo { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public uint Entidade { get; set; }

    public decimal ValorFact { get; set; }

    public uint OfficeId { get; set; }
}
