namespace Data.Models;

internal partial class Matatrib
{
    public uint MatAtribAuxId { get; set; }

    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public string Dente { get; set; } = null!;

    public uint? Clinico { get; set; }

    public uint CodMat { get; set; }

    public short Comport { get; set; }

    public uint OfficeId { get; set; }
}
