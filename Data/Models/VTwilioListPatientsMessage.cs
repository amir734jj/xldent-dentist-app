namespace Data.Models;

internal partial class VTwilioListPatientsMessage
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public uint? Prespparty { get; set; }

    public string? PatientName { get; set; }

    public uint? DoctorId { get; set; }

    public string? DoctorName { get; set; }

    public string? NumberFrom { get; set; }

    public string? NumberTo { get; set; }

    public string? TextMessage { get; set; }

    public string? MessageType { get; set; }

    public DateTime? Date { get; set; }

    public TimeSpan? Time { get; set; }
}
