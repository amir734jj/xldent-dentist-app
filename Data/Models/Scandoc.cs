namespace Data.Models;

internal partial class Scandoc
{
    public uint Auxauto { get; set; }

    public uint? Pac { get; set; }

    public string? Description { get; set; }

    public DateTime? DateEntered { get; set; }

    public byte[]? Image { get; set; }

    public uint OfficeId { get; set; }
}
