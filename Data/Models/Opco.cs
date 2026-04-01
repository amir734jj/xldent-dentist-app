namespace Data.Models;

internal partial class Opco
{
    public uint? RecordId { get; set; }

    public string SoTratInicial { get; set; } = null!;

    public string ApresLupa { get; set; } = null!;

    public byte[]? Logotipo { get; set; }

    public byte DocIniFac { get; set; }

    public string MostraFaltas { get; set; } = null!;

    public uint? CorPerMes { get; set; }

    public string AvisaAnivers { get; set; } = null!;

    public string? DirAppRxDaview { get; set; }

    public string? DirAppRxRvg { get; set; }

    public string? DirAppRxVw { get; set; }

    public string? DirAppRxDigora { get; set; }

    public string? DirAppRx { get; set; }

    public byte TipoAppRx { get; set; }

    public string ImprimeFichaEnvelope { get; set; } = null!;

    public string? EmailHost { get; set; }

    public string? EmailUser { get; set; }

    public string? EmailNome { get; set; }

    public string? EmailAddress { get; set; }

    public string NetAutoConnect { get; set; } = null!;

    public string NetAutoDisconnect { get; set; } = null!;

    public string FacturaMultiClinico { get; set; } = null!;

    public string? DirReports { get; set; }

    public byte? ProgNoteLock { get; set; }

    public string ToothChart { get; set; } = null!;

    public sbyte PerioLinesGap { get; set; }

    public uint OfficeId { get; set; }
}
