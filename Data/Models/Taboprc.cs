namespace Data.Models;

internal partial class Taboprc
{
    public uint? Acod { get; set; }

    public byte Aclass { get; set; }

    public string AnomeOper { get; set; } = null!;

    public string Acond { get; set; } = null!;

    public uint OfficeId { get; set; }
}
