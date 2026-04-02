namespace XLDENTProxy.Models;

internal partial class Defdoc
{
    public string TipoDef { get; set; } = null!;

    public uint? Cod { get; set; }

    public string Nome { get; set; } = null!;

    public string NomeImp { get; set; } = null!;

    public string TipoEcran { get; set; } = null!;

    public uint SeqDoc { get; set; }

    public byte ViasDoc { get; set; }

    public string Impressao { get; set; } = null!;

    public string DebCreCaixa { get; set; } = null!;

    public string MovCaixa { get; set; } = null!;

    public sbyte MargemEsq { get; set; }

    public sbyte MargemTop { get; set; }

    public string ImprimeCab { get; set; } = null!;

    public string ImprimeLogo { get; set; } = null!;

    public string CabAlternativo { get; set; } = null!;

    public string Rodape { get; set; } = null!;

    public string Rodape2 { get; set; } = null!;

    public string Portrait { get; set; } = null!;

    public string DebCaixaCli { get; set; } = null!;

    public string DebCaixaFor { get; set; } = null!;

    public string CreCaixaCli { get; set; } = null!;

    public string CreCaixaFor { get; set; } = null!;

    public string DebCcCli { get; set; } = null!;

    public string DebCcFor { get; set; } = null!;

    public string CreCcCli { get; set; } = null!;

    public string CreCcFor { get; set; } = null!;

    public uint OfficeId { get; set; }
}
