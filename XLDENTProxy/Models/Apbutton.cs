namespace XLDENTProxy.Models;

internal partial class Apbutton
{
    public uint SeqId { get; set; }

    public byte ButtonId { get; set; }

    public string CodT { get; set; } = null!;

    public string? Caption { get; set; }

    public uint? CategoryId { get; set; }

    public uint OfficeId { get; set; }
}
