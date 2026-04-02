namespace XLDENTProxy.Models;

internal partial class Cell
{
    public int CellAuxAuto { get; set; }

    public string MobileCarrier { get; set; } = null!;

    public string EmailToText { get; set; } = null!;

    public uint OfficeId { get; set; }
}
