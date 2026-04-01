namespace Data.Models;

internal partial class Prognotepd
{
    public uint NoteId { get; set; }

    public uint ParentId { get; set; }

    public uint? NoteGroup { get; set; }

    public string? NoteGroupCaption { get; set; }

    public string Caption { get; set; } = null!;

    public string? Note { get; set; }

    public uint OfficeId { get; set; }
}
