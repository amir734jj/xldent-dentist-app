namespace Data.Models;

internal partial class ScheduledRelease
{
    public int Id { get; set; }

    public DateTime ScheduledDate { get; set; }

    public string VersionName { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Downloaded { get; set; } = null!;

    public string Applied { get; set; } = null!;

    public string Onerror { get; set; } = null!;

    public string OnerrorLog { get; set; } = null!;

    public string UpgradedBridge { get; set; } = null!;

    public string PathBridge { get; set; } = null!;

    public int ReleaseId { get; set; }
}
