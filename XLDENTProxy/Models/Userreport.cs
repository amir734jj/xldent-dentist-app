namespace XLDENTProxy.Models;

internal partial class Userreport
{
    public string ReportName { get; set; } = null!;

    public string ReportFile { get; set; } = null!;

    public string? Caption { get; set; }

    public byte[]? Logo16 { get; set; }

    public byte[]? Logo32 { get; set; }

    public string? AppMenu { get; set; }

    public string? AppAgenda { get; set; }

    public string? AppEspec { get; set; }

    public string? AppFichasPac { get; set; }

    public string? AppFact { get; set; }

    public string? AppTab { get; set; }

    public string? AppDentalChart { get; set; }

    public string ReportField { get; set; } = null!;

    public string? JoinTable { get; set; }

    public string? JoinTableField { get; set; }

    public string? JoinTableFieldType { get; set; }

    public string? JoinTableFieldShow { get; set; }

    public string? JoinBaseFieldExt { get; set; }

    public string? JoinTableFieldExt { get; set; }

    public string? JoinAux { get; set; }

    public string? JoinAuxField { get; set; }

    public string? Sql { get; set; }

    public string? OrderFields { get; set; }

    public string? CallAutoReport1 { get; set; }

    public string? CallAutoReport2 { get; set; }

    public string? CallAutoReport3 { get; set; }

    public uint OfficeId { get; set; }
}
