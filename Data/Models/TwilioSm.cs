namespace Data.Models;

internal partial class TwilioSm
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public int UserId { get; set; }

    public string? NumberFrom { get; set; }

    public string? NumberTo { get; set; }

    public string? TextMessage { get; set; }

    public string? SidTwilio { get; set; }

    public string? Sended { get; set; }

    public string? Readed { get; set; }

    public string? TypeMessage { get; set; }

    public DateTime Timestamp { get; set; }

    public int OfficeId { get; set; }
}
