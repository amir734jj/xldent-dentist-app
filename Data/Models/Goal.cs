namespace Data.Models;

internal partial class Goal
{
    public uint GoalAuxAuto { get; set; }

    public uint ResourceId { get; set; }

    public DateTime? GoalDate { get; set; }

    public uint OfficeId { get; set; }
}
