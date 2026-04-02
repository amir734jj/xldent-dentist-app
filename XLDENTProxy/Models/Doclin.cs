namespace XLDENTProxy.Models;

internal partial class Doclin
{
    public uint? TipDoc { get; set; }

    public uint Terc { get; set; }

    public uint Ndoc { get; set; }

    public uint AuxAutoInc { get; set; }

    public byte FacEnt { get; set; }

    public string Dente { get; set; } = null!;

    public string CodTt { get; set; } = null!;

    public int Faces { get; set; }

    public DateTime Dia { get; set; }

    public DateTime DiaTrt { get; set; }

    public uint? Clinico { get; set; }

    public uint? Entid { get; set; }

    public string Guia { get; set; } = null!;

    public string Benef { get; set; } = null!;

    public string Anul { get; set; } = null!;

    public string Assinado { get; set; } = null!;

    public string DescLin { get; set; } = null!;

    public decimal ValPac { get; set; }

    public decimal ValEnt { get; set; }

    public string Deb { get; set; } = null!;

    public short Desconto { get; set; }

    public uint NguiaTt { get; set; }

    public int Especialidade { get; set; }

    public uint OfficeId { get; set; }
}
