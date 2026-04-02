namespace XLDENTProxy.Models;

internal partial class Especialidade
{
    public uint? CodEsp { get; set; }

    public string NomeEsp { get; set; } = null!;

    public byte[]? Icon { get; set; }

    public string? SpCode { get; set; }

    public string? ProvType { get; set; }

    public uint OfficeId { get; set; }
}
