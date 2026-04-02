namespace XLDENTProxy.Models;

internal partial class Periodontium
{
    public uint Pac { get; set; }

    public uint AuxAuto { get; set; }

    public string VestLingual { get; set; } = null!;

    public string? Dente { get; set; }

    public string? ChildTooth { get; set; }

    public DateTime? Mob1Dia { get; set; }

    public DateTime? Mob2Dia { get; set; }

    public DateTime? Mob3Dia { get; set; }

    public byte? Mob1 { get; set; }

    public byte? Mob2 { get; set; }

    public byte? Mob3 { get; set; }

    public string? MobObs { get; set; }

    public DateTime? Bolsa1Dia { get; set; }

    public DateTime? Bolsa2Dia { get; set; }

    public DateTime? Bolsa3Dia { get; set; }

    public DateTime? Bolsa4Dia { get; set; }

    public DateTime? Bolsa5Dia { get; set; }

    public string? Bolsa1 { get; set; }

    public string? Bolsa2 { get; set; }

    public string? Bolsa3 { get; set; }

    public string? Bolsa4 { get; set; }

    public string? Bolsa5 { get; set; }

    public string? BolsaObs { get; set; }

    public byte? Furca { get; set; }

    public byte? Furca2 { get; set; }

    public byte? Furca3 { get; set; }

    public string? FurcaObs { get; set; }

    public string? ImpactaDnt { get; set; }

    public string? Recession { get; set; }

    public string? BleedingM { get; set; }

    public string? BleedingC { get; set; }

    public string? BleedingD { get; set; }

    public string? SuppurationM { get; set; }

    public string? SuppurationC { get; set; }

    public string? SuppurationD { get; set; }

    public string? PlaqueM { get; set; }

    public string? PlaqueC { get; set; }

    public string? PlaqueD { get; set; }

    public string? CalculusM { get; set; }

    public string? CalculusC { get; set; }

    public string? CalculusD { get; set; }

    public sbyte? Pdm { get; set; }

    public sbyte? Pdc { get; set; }

    public sbyte? Pdd { get; set; }

    public sbyte? Gmm { get; set; }

    public sbyte? Gmc { get; set; }

    public sbyte? Gmd { get; set; }

    public sbyte? Mgjm { get; set; }

    public sbyte? Mgjc { get; set; }

    public sbyte? Mgjd { get; set; }

    public uint OfficeId { get; set; }
}
