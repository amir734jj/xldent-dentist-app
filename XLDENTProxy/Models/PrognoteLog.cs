namespace XLDENTProxy.Models;

internal partial class PrognoteLog
{
    public uint NoteSeq { get; set; }

    public DateTime? NoteDate { get; set; }

    public TimeSpan? NoteTime { get; set; }

    public DateTime? NoteLinkDate { get; set; }

    public uint? NoteId { get; set; }

    public uint? UserId { get; set; }

    public uint? PatientId { get; set; }

    public string? NoteMessage { get; set; }

    public string? NoteText { get; set; }

    public uint OfficeId { get; set; }

    public string Kind { get; set; } = null!;
}
