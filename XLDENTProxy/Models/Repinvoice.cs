namespace XLDENTProxy.Models;

internal partial class Repinvoice
{
    public string RepName { get; set; } = null!;

    public byte[]? RepTemplate { get; set; }

    public uint OfficeId { get; set; }
}
