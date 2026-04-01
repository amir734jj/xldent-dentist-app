namespace Data.Models;

internal partial class Tratref
{
    public uint AuxAuto { get; set; }

    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Trat { get; set; } = null!;

    public string? TrtDesc { get; set; }

    public TimeSpan Time { get; set; }

    public string Surface { get; set; } = null!;

    public string Tooth { get; set; } = null!;

    public string Provider { get; set; } = null!;

    public decimal? ValuePac { get; set; }

    public string OtherData { get; set; } = null!;

    public uint OfficeId { get; set; }
}
