namespace XLDENTProxy.Models;

internal partial class Sigdoc
{
    public uint SeqId { get; set; }

    public byte? DocType { get; set; }

    public DateTime DateEntered { get; set; }

    public string? DocName { get; set; }

    public string Locked { get; set; } = null!;

    public byte[] DocText { get; set; } = null!;

    public string Active { get; set; } = null!;

    public uint OfficeId { get; set; }
}
