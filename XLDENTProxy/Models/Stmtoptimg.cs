namespace XLDENTProxy.Models;

internal partial class Stmtoptimg
{
    public int Id { get; set; }

    public DateTime? Sdate { get; set; }

    public TimeSpan? Stime { get; set; }

    public uint? UserId { get; set; }

    public byte[]? OptionsImage { get; set; }

    public uint OfficeId { get; set; }
}
