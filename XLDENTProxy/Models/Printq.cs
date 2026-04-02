namespace XLDENTProxy.Models;

internal partial class Printq
{
    public uint Auxauto { get; set; }

    public uint? Pac { get; set; }

    public string? Description { get; set; }

    public DateTime? DateEntered { get; set; }

    public byte[]? Image { get; set; }

    public string? Email { get; set; }

    public string? EventId { get; set; }

    public string? MsgType { get; set; }

    public string? Archive { get; set; }

    public uint OfficeId { get; set; }
}
