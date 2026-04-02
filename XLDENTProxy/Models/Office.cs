namespace XLDENTProxy.Models;

internal partial class Office
{
    public uint OfficeId { get; set; }

    public string OfficeName { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? WebAddress { get; set; }

    public string? ExternalIp { get; set; }

    public string? Email { get; set; }

    public string? FedTin { get; set; }

    public string? Npitype2 { get; set; }

    public string? Active { get; set; }

    public int? ForClaimsUseOffice { get; set; }

    public int FeeId { get; set; }
}
