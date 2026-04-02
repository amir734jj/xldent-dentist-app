namespace XLDENTProxy.Models;

internal partial class VTwilioListPatient
{
    public int PatientId { get; set; }

    public int Id { get; set; }

    public string? PatientName { get; set; }

    public string? NumberFrom { get; set; }

    public string? NumberTo { get; set; }

    public string? OwnerSms { get; set; }

    public byte[]? Picture { get; set; }

    public DateTime? CurrTimestamp { get; set; }

    public string? LastMessage { get; set; }

    public int OfficeId { get; set; }
}
