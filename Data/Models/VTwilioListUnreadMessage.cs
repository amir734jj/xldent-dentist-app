namespace Data.Models;

internal partial class VTwilioListUnreadMessage
{
    public int PatientId { get; set; }

    public int Id { get; set; }

    public string? PatientName { get; set; }

    public string? NumberFrom { get; set; }

    public string? NumberTo { get; set; }

    public string? OwnerSms { get; set; }

    public byte[]? Picture { get; set; }

    public string? TextMessage { get; set; }

    public DateTime Timestamp { get; set; }

    public int OfficeId { get; set; }
}
