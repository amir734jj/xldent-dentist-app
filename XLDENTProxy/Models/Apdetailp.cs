namespace XLDENTProxy.Models;

internal partial class Apdetailp
{
    public uint SeqId { get; set; }

    public string EventId { get; set; } = null!;

    public string? CodT { get; set; }

    public string? Tooth { get; set; }

    public string? Surface { get; set; }

    public byte? Face { get; set; }

    public string? Guia { get; set; }

    public uint AuxAutoTrt { get; set; }

    public uint AuxAutoPlan { get; set; }

    public uint OfficeId { get; set; }
}
