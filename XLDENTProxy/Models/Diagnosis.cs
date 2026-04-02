namespace XLDENTProxy.Models;

internal partial class Diagnosis
{
    public int Id { get; set; }

    public string TypeDiagnosis { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;
}
