namespace Data.Models;

internal partial class Prognote
{
    public uint AuxAuto { get; set; }

    public uint? Pac { get; set; }

    public DateTime? LinkDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public TimeSpan? CreateTime { get; set; }

    public uint? CreatedBy { get; set; }

    public uint? AuxAutoTrt { get; set; }

    public string? Trat { get; set; }

    public string? Locked { get; set; }

    public DateTime? LockedDate { get; set; }

    public uint? NoteOrder { get; set; }

    public string? Note { get; set; }

    public uint OfficeId { get; set; }

    public string? LockRow { get; set; }
}
