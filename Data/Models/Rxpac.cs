namespace Data.Models;

internal partial class Rxpac
{
    public uint RxId { get; set; }

    public uint? Pac { get; set; }

    public DateTime? CreateDate { get; set; }

    public uint? CreatedBy { get; set; }

    public uint? DoctorId { get; set; }

    public string? Medicine { get; set; }

    public string? Dosage { get; set; }

    public string? Dispense { get; set; }

    public string? Refills { get; set; }

    public string? Notes { get; set; }

    public uint? DoseRxId { get; set; }

    public string? DoseRxstatus { get; set; }

    public uint OfficeId { get; set; }
}
