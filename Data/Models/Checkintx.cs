namespace Data.Models;

internal partial class Checkintx
{
    public uint CheckinId { get; set; }

    public string? SkinName { get; set; }

    public string? Text1 { get; set; }

    public string? Text1Font { get; set; }

    public uint? Text1Color { get; set; }

    public byte? Text1Size { get; set; }

    public string? Text2 { get; set; }

    public string? Text2Font { get; set; }

    public uint? Text2Color { get; set; }

    public byte? Text2Size { get; set; }

    public string? Text3 { get; set; }

    public string? Text3Font { get; set; }

    public uint? Text3Color { get; set; }

    public byte? Text3Size { get; set; }

    public byte? ResetSecs { get; set; }

    public uint OfficeId { get; set; }
}
