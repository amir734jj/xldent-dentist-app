namespace Data.Models;

internal partial class DiagnosisTabelat
{
    public int Id { get; set; }

    public string CodT { get; set; } = null!;

    public int DiagnosisId { get; set; }
}
