namespace XLDENTProxy.Models;

internal partial class Acessosoper
{
    public uint? TipoAcesso { get; set; }

    public byte Classif { get; set; }

    public ushort Operacao { get; set; }

    public string Condicionada { get; set; } = null!;

    public uint OfficeId { get; set; }
}
