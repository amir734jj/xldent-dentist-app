namespace XLDENTProxy.Models;

internal partial class Stmttemp
{
    public uint RespParty { get; set; }

    public string? ChrgInterest { get; set; }

    public string? SendDunning { get; set; }

    public decimal? Current { get; set; }

    public decimal? Days30 { get; set; }

    public decimal? Days60 { get; set; }

    public decimal? Days90 { get; set; }

    public uint OfficeId { get; set; }
}
