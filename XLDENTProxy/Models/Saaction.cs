namespace XLDENTProxy.Models;

internal partial class Saaction
{
    public uint Said { get; set; }

    public string GroupName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string Allow { get; set; } = null!;

    public uint OfficeId { get; set; }
}
