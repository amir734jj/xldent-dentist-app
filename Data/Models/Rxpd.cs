namespace Data.Models;

internal partial class Rxpd
{
    public uint RxId { get; set; }

    public string? Medicine { get; set; }

    public string? Dosage { get; set; }

    public string? Dispense { get; set; }

    public string? Refills { get; set; }

    public string? Notes { get; set; }

    public uint OfficeId { get; set; }
}
