namespace Data.Models;

internal partial class Toothloc
{
    public string Tooth { get; set; } = null!;

    public string? Location { get; set; }

    public string? ToothKind { get; set; }

    public uint OfficeId { get; set; }
}
