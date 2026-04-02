namespace XLDENTProxy.Models;

internal partial class Inkformq
{
    public uint InkqAuxAuto { get; set; }

    public uint InkFormId { get; set; }

    public uint ParentId { get; set; }

    public uint Pac { get; set; }

    public string? Forced { get; set; }

    public string Caption { get; set; } = null!;

    public DateTime? DateEntered { get; set; }

    public uint? PageOrder { get; set; }

    public string? Location { get; set; }

    public string? Locked { get; set; }

    public byte[]? Image { get; set; }

    public uint OfficeId { get; set; }
}
