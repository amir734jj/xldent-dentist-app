namespace XLDENTProxy.Models;

internal partial class Stmtopt
{
    public byte Id { get; set; }

    public decimal? PrintBalance { get; set; }

    public string? PrintCredit { get; set; }

    public uint? LastSentDays { get; set; }

    public string? InsPending { get; set; }

    public byte? DueDays { get; set; }

    public decimal? MinServiceFee { get; set; }

    public decimal? DunMinBalance { get; set; }

    public string? DunMsgOn { get; set; }

    public byte? ServFeeDays { get; set; }

    public decimal? Apr { get; set; }

    public string? MsgCurrent { get; set; }

    public string? MsgAll { get; set; }

    public string? MsgDun30 { get; set; }

    public string? MsgDun60 { get; set; }

    public string? MsgDun90 { get; set; }

    public string? MsgServFee { get; set; }

    public string? Esp { get; set; }

    public string Visa { get; set; } = null!;

    public string MasterCard { get; set; } = null!;

    public string Discover { get; set; } = null!;

    public string AmExpress { get; set; } = null!;

    public uint? ServFeeInt { get; set; }

    public string? PastHistory { get; set; }

    public uint OfficeId { get; set; }
}
