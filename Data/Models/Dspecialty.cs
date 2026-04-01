namespace Data.Models;

internal partial class Dspecialty
{
    public uint CodEsp { get; set; }

    public string NomeEsp { get; set; } = null!;

    public string? SpCode { get; set; }

    public string? ProvType { get; set; }

    public byte[]? Icon { get; set; }

    public uint OfficeId { get; set; }
}
