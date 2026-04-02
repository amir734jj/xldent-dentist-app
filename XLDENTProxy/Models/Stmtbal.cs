namespace XLDENTProxy.Models;

internal partial class Stmtbal
{
    public uint AuxAuto { get; set; }

    public uint StatementId { get; set; }

    public DateTime? Sdate { get; set; }

    public uint? RespParty { get; set; }

    public decimal? Balance { get; set; }

    public uint OfficeId { get; set; }
}
