namespace XLDENTProxy.Models;

internal partial class Terceiro
{
    public uint Numero { get; set; }

    public byte Genero { get; set; }

    public string Nome { get; set; } = null!;

    public string? Morada { get; set; }

    public string? Localid { get; set; }

    public string? CodPos { get; set; }

    public string? Telef1 { get; set; }

    public string? Telef2 { get; set; }

    public string? TelMov { get; set; }

    public string? Contrib { get; set; }

    public string? Email { get; set; }

    public string? Www { get; set; }

    public string? MemoObs { get; set; }

    public byte[]? Foto { get; set; }

    public uint OfficeId { get; set; }
}
