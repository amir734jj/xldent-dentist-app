namespace XLDENTProxy.Models;

internal partial class Toothstat
{
    public uint PatientNumber { get; set; }

    public string ToothPage { get; set; } = null!;

    public uint OfficeId { get; set; }
}
