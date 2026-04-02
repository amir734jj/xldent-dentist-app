namespace XLDENTProxy.Models;

internal partial class Receita
{
    public uint Mecano { get; set; }

    public DateTime Dia { get; set; }

    public uint IndexRec { get; set; }

    public string? Titulo { get; set; }

    public byte[]? Texto { get; set; }

    public uint OfficeId { get; set; }
}
