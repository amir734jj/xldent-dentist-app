namespace XLDENTProxy.Models;

internal partial class Fieldsdescription
{
    public string FileName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string JoinAux { get; set; } = null!;

    public short? ReferenceTable { get; set; }

    public string? JoinField { get; set; }

    public string? FieldCalc { get; set; }

    public uint OfficeId { get; set; }
}
