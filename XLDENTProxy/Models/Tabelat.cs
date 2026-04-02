namespace XLDENTProxy.Models;

internal partial class Tabelat
{
    public uint? Especialidade { get; set; }

    public string CodT { get; set; } = null!;

    public uint? Entidade { get; set; }

    public string Abrev { get; set; } = null!;

    public string Desactivar { get; set; } = null!;

    public string? CodE { get; set; }

    public string? NomeT { get; set; }

    public string Especial { get; set; } = null!;

    public uint? TipoTrat { get; set; }

    public byte[]? Grafico { get; set; }

    public byte AprGraf { get; set; }

    public string TiraDente { get; set; } = null!;

    public string ValUnit { get; set; } = null!;

    public decimal ValEntid { get; set; }

    public decimal ValBenef { get; set; }

    public byte Meses { get; set; }

    public string Factura { get; set; } = null!;

    public int ShpForma { get; set; }

    public int ShpAltura { get; set; }

    public int ShpLargura { get; set; }

    public int ShpCorB { get; set; }

    public int ShpCorF { get; set; }

    public int ShpTipoLin { get; set; }

    public int ShpEspLin { get; set; }

    public int ShpEnchim { get; set; }

    public string MesesPorDente { get; set; } = null!;

    public string MarcaFaces { get; set; } = null!;

    public string ImprimeUltimoDia { get; set; } = null!;

    public uint? CodComissao { get; set; }

    public string AvisaAuto { get; set; } = null!;

    public string? TrtKind { get; set; }

    public string? TrtClass { get; set; }

    public string? NeedQuad { get; set; }

    public string ShowShapes { get; set; } = null!;

    public string? ProgressNote { get; set; }

    public string? UseMaterial { get; set; }

    public string? TrtRecall { get; set; }

    public string? Location { get; set; }

    public string? FlexGroup { get; set; }

    public byte? SurfacesReq { get; set; }

    public string? ToothKind { get; set; }

    public string? ToothType { get; set; }

    public uint OfficeId { get; set; }
}
