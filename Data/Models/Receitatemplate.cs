namespace Data.Models;

internal partial class Receitatemplate
{
    public string Doctor { get; set; } = null!;

    public byte[]? ReceitaTemplate { get; set; }

    public uint OfficeId { get; set; }
}
