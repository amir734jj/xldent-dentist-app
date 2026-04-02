namespace XLDENTProxy.Models;

internal partial class Inkformpd
{
    public uint InkFormId { get; set; }

    public uint ParentId { get; set; }

    public string Caption { get; set; } = null!;

    public DateTime? DateEntered { get; set; }

    public uint? PageOrder { get; set; }

    public string? Location { get; set; }

    public string? FormLocation { get; set; }

    public string? Locked { get; set; }

    public uint? MonthFreq { get; set; }

    public byte[]? Image { get; set; }

    public string? Dfm { get; set; }

    public string? Htmlfm { get; set; }

    public sbyte? Stage { get; set; }

    public string? FormValues { get; set; }

    public sbyte PageKind { get; set; }

    public uint OfficeId { get; set; }
}
