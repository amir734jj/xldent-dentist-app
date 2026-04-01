namespace Data.Models;

internal partial class Prognoteref
{
    public uint AuxAuto { get; set; }

    public uint? Pac { get; set; }

    public DateTime? CreateDate { get; set; }

    public TimeSpan? CreateTime { get; set; }

    public string? Provider { get; set; }

    public string? Note { get; set; }

    public uint OfficeId { get; set; }
}
