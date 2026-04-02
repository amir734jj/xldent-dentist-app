namespace XLDENTProxy.Models;

internal partial class Tabelap
{
    public string CodT { get; set; } = null!;

    public string? Abrev { get; set; }

    public string? Billable { get; set; }

    public string? NameP { get; set; }

    public string Inactive { get; set; } = null!;

    public string Credit { get; set; } = null!;

    public uint? Category { get; set; }

    public string? AdjType { get; set; }

    public string? Warning { get; set; }

    public uint RptGroupId { get; set; }

    public uint OfficeId { get; set; }
}
