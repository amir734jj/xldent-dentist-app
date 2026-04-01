namespace Data.Models;

/// <summary>
/// StateTin=NPI Type 1,Medicaid=NPI Type 2
/// </summary>
internal partial class Medico
{
    public uint Codigo { get; set; }

    public string Activo { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public byte TipoAcesso { get; set; }

    public byte Espec { get; set; }

    public string? CalcPerc { get; set; }

    public decimal? ValPerc { get; set; }

    public decimal? ValTrat { get; set; }

    public string Email { get; set; } = null!;

    public string? NomeA { get; set; }

    public string? PassA { get; set; }

    public string? AceitaMsg { get; set; }

    public string? Cedula { get; set; }

    public string? ConfirmaMarcaTrt { get; set; }

    public sbyte CodComissao { get; set; }

    public string? BotoesTrat { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MiddleInit { get; set; } = null!;

    public string? HomePhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? Ssn { get; set; }

    public string? FedTin { get; set; }

    public string? StateTin { get; set; }

    public string? LicenseNo { get; set; }

    public string? Dea { get; set; }

    public string? MedicAid { get; set; }

    public string? ProviderCd { get; set; }

    public string? Specialty { get; set; }

    public string? SpCode { get; set; }

    public string? ProvType { get; set; }

    public byte? Fee { get; set; }

    public string? InsId1 { get; set; }

    public string? InsId2 { get; set; }

    public string? InsId3 { get; set; }

    public string? InsId4 { get; set; }

    public string? InsId5 { get; set; }

    public string? InsId6 { get; set; }

    public string? InsId7 { get; set; }

    public string? InsId8 { get; set; }

    public string? InsId9 { get; set; }

    public string? InsId10 { get; set; }

    public int? ProvColor { get; set; }

    public int? ProgNoteGroup { get; set; }

    public string ClaimPayProvider { get; set; } = null!;

    public string UseTimeClock { get; set; } = null!;

    public string? CardData { get; set; }

    public string TimeClockAdmin { get; set; } = null!;

    public string? SecurityGroup { get; set; }

    public int? DoseUserId { get; set; }

    public string? LocName { get; set; }

    public string? LocAddress1 { get; set; }

    public string? LocAddress2 { get; set; }

    public string? LocCity { get; set; }

    public string? LocState { get; set; }

    public string? LocZip { get; set; }

    public string? PlaceOfTrt { get; set; }

    public string? LocNpi2 { get; set; }

    public string? EhruserId { get; set; }

    public string? EhruserPass { get; set; }

    public string? LocFax { get; set; }

    public string? LocEmail { get; set; }

    public string? LocPhone { get; set; }

    public string? EhrfacilityId { get; set; }

    public DateTime? ChangedOn { get; set; }

    public string? UseLocForIns { get; set; }

    public uint OfficeId { get; set; }

    public uint FeeId { get; set; }
}
