namespace XLDENTProxy.Models;

internal partial class Userreptemplate
{
    public string RbnameField { get; set; } = null!;

    public byte[] Rbtemplate { get; set; } = null!;

    public string? Rbdescription { get; set; }

    public string? Rbquery { get; set; }

    public uint? RbmenuTag { get; set; }

    public byte[]? Logo16 { get; set; }

    public byte[]? Logo32 { get; set; }

    public uint OfficeId { get; set; }
}
