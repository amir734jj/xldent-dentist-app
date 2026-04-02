namespace XLDENTProxy.Models;

internal partial class Stmt
{
    public uint StatementId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? Sdate { get; set; }

    public DateTime? DueDate { get; set; }

    public uint? RespParty { get; set; }

    public string? Print { get; set; }

    public string? Printed { get; set; }

    public string? StmtType { get; set; }

    public string? Message { get; set; }

    public string? PersonalMsg { get; set; }

    public string? DunMsg { get; set; }

    public string? MsgServFee { get; set; }

    public decimal? Current { get; set; }

    public decimal? Days30 { get; set; }

    public decimal? Days60 { get; set; }

    public decimal? Days90 { get; set; }

    public decimal? OverPay { get; set; }

    public decimal? FinCharge { get; set; }

    public decimal? NewBalance { get; set; }

    public decimal? OldBalance { get; set; }

    public decimal? EstInsValue { get; set; }

    public decimal? EstDueValue { get; set; }

    public decimal? LastBalance { get; set; }

    public decimal? PatEstDueValue { get; set; }

    public decimal? AmountDue { get; set; }

    public uint OfficeId { get; set; }
}
