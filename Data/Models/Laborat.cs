namespace Data.Models;

internal partial class Laborat
{
    public uint CodLab { get; set; }

    public string LabName { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? WebAddress { get; set; }

    public uint OfficeId { get; set; }
}
