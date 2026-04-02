namespace XLDENTProxy.Models;

internal partial class Olkopt
{
    public byte Id { get; set; }

    public string? TrtCode { get; set; }

    public string? TrtDesc { get; set; }

    public string TrtTooth { get; set; } = null!;

    public string TrtSurface { get; set; } = null!;

    public string PatientPhones { get; set; } = null!;

    public string? PatientEmail { get; set; }

    public string? PatientAddress { get; set; }

    public string? PatientAge { get; set; }

    public string? Balance { get; set; }

    public string? Prescriptions { get; set; }

    public string? PrescAlerts { get; set; }

    public string? ClearOutlook { get; set; }

    public uint OfficeId { get; set; }
}
