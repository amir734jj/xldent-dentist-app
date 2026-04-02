namespace XLDENTProxy.Models;

internal partial class FeeScheduleItem
{
    public int Id { get; set; }

    public int FeeId { get; set; }

    public string CodT { get; set; } = null!;

    public decimal FeeValue { get; set; }
}
