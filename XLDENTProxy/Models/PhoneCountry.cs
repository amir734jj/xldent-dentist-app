namespace XLDENTProxy.Models;

internal partial class PhoneCountry
{
    public int Phonecode { get; set; }

    public string Iso { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Nicename { get; set; } = null!;

    public string? Iso3 { get; set; }

    public short? Numcode { get; set; }
}
