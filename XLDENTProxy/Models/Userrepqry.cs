namespace XLDENTProxy.Models;

internal partial class Userrepqry
{
    public string ReportName { get; set; } = null!;

    public string? QueryDesc { get; set; }

    public string QueryField { get; set; } = null!;

    public string? QueryOper { get; set; }

    public string? QueryType { get; set; }

    public string? QueryValue1 { get; set; }

    public string? QueryValue2 { get; set; }

    public string? QueryValueEnum { get; set; }

    public short? QueryRefTable { get; set; }

    public uint OfficeId { get; set; }
}
