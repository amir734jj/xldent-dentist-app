namespace XLDENTProxy.Models;

internal partial class Userrepmlink
{
    public string ReportName { get; set; } = null!;

    public string FileNameRel { get; set; } = null!;

    public string FieldNameBase { get; set; } = null!;

    public string FieldNameRel { get; set; } = null!;

    public string FieldShowRel { get; set; } = null!;

    public string FieldShowRelType { get; set; } = null!;

    public uint OfficeId { get; set; }
}
