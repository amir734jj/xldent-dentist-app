namespace XLDENTProxy.Models;

internal partial class Referral
{
    public uint ReferralId { get; set; }

    public string? RefSource { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Notes { get; set; }

    public uint OfficeId { get; set; }
}
