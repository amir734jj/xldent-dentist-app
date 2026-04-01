namespace Data.Models;

internal partial class Employer
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public uint OfficeId { get; set; }
}
