namespace Data.Models;

internal partial class Sigpat
{
    public uint AuxAuto { get; set; }

    public uint RecordNo { get; set; }

    public byte[] SigImage { get; set; } = null!;

    public DateTime? DateSigned { get; set; }

    public uint DocSeqId { get; set; }

    public uint OfficeId { get; set; }
}
