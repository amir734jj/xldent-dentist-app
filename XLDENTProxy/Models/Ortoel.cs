namespace XLDENTProxy.Models;

internal partial class Ortoel
{
    public uint Pac { get; set; }

    public string ToothFrom { get; set; } = null!;

    public string ToothTo { get; set; } = null!;

    public DateTime ElasticDate { get; set; }

    public int ElasticColor { get; set; }

    public int ElasticId { get; set; }

    public string ElasticDesc { get; set; } = null!;

    public string WireDescUpper { get; set; } = null!;

    public string WireDescLower { get; set; } = null!;

    public string Active { get; set; } = null!;

    public uint OfficeId { get; set; }
}
