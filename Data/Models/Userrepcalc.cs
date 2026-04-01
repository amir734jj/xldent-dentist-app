namespace Data.Models;

internal partial class Userrepcalc
{
    public string ReportName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string? CalcExpression { get; set; }

    public short? DecimalRound { get; set; }

    public string? FieldType { get; set; }

    public uint OfficeId { get; set; }
}
