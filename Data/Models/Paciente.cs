namespace Data.Models;

internal partial class Paciente
{
    public uint Pmecano { get; set; }

    public uint PcartaoCredito { get; set; }

    public string Pnome { get; set; } = null!;

    public uint Pprocesso { get; set; }

    public DateTime? PdiaProces { get; set; }

    public string? Pmorada { get; set; }

    public string? Plocalid { get; set; }

    public string? PcodPos { get; set; }

    public DateTime? Pnascim { get; set; }

    public string? Panivers { get; set; }

    public string? PtlfEmpr { get; set; }

    public string? PtlfCasa { get; set; }

    public string? Pcontrib { get; set; }

    public string? Pbenefi { get; set; }

    public string? Ptitular { get; set; }

    public uint? Pentidade { get; set; }

    public uint? Pprofis { get; set; }

    public string Pmascul { get; set; } = null!;

    public string Pecivil { get; set; } = null!;

    public byte Pfilhos { get; set; }

    public DateTime? Papresent { get; set; }

    public DateTime? PultCons { get; set; }

    public string? PultConAnoMes { get; set; }

    public string? Pemail { get; set; }

    public string Pcorresp { get; set; } = null!;

    public byte Pmeses { get; set; }

    public uint Pmedico { get; set; }

    public DateTime? PvalCartao { get; set; }

    public string? PmemoObs { get; set; }

    public byte[]? Pfoto { get; set; }

    public string? PdirRad { get; set; }

    public string? PdirImg { get; set; }

    public string? PdirTrophy { get; set; }

    public string? PindicadoPor { get; set; }

    public string? Ptmovel { get; set; }

    public string? Ptitulo { get; set; }

    public string? PnumBi { get; set; }

    public string? ParqBi { get; set; }

    public DateTime? PdataBi { get; set; }

    public string? PpayWarning { get; set; }

    public uint PrespParty { get; set; }

    public string? Pfirst { get; set; }

    public string? Plast { get; set; }

    public string? Pmiddle { get; set; }

    public string? Ppreferred { get; set; }

    public string? Pcity { get; set; }

    public string? Pstate { get; set; }

    public string? Pzip { get; set; }

    public DateTime? PfirstVisit { get; set; }

    public string? Prelation { get; set; }

    public string? PrelationIns1 { get; set; }

    public uint? PsubAccount1 { get; set; }

    public string? Pstatus { get; set; }

    public byte? PrecallFreq { get; set; }

    public string? Pssn { get; set; }

    public string? Pfax { get; set; }

    public string? Pcountry { get; set; }

    public byte? PcontactMethod { get; set; }

    public DateTime? LastRcvisit { get; set; }

    public DateTime? Tpoconsent { get; set; }

    public int? InsuranceId1 { get; set; }

    public int? InsuranceId2 { get; set; }

    public uint PlanId1 { get; set; }

    public uint PlanId2 { get; set; }

    public decimal? PatDeductible1 { get; set; }

    public decimal? PatDeductible2 { get; set; }

    public decimal? MaxBenefit1 { get; set; }

    public decimal? MaxBenefit2 { get; set; }

    public string? EmployerName1 { get; set; }

    public string? EmployerName2 { get; set; }

    public string? EmploymentStatus1 { get; set; }

    public string? EmploymentStatus2 { get; set; }

    public string? SchoolName1 { get; set; }

    public string? SchoolName2 { get; set; }

    public DateTime? Anniversary1 { get; set; }

    public DateTime? Anniversary2 { get; set; }

    public string? GroupNumber1 { get; set; }

    public string? GroupNumber2 { get; set; }

    public string? BenAssign1 { get; set; }

    public string? BenAssign2 { get; set; }

    public string? InsCardId1 { get; set; }

    public string? InsCardId2 { get; set; }

    public uint? RefAccount { get; set; }

    public int? RefSourceId { get; set; }

    public string? ReferredTo { get; set; }

    public DateTime? RefDate { get; set; }

    public uint? DoctorId { get; set; }

    public uint? HygenistId { get; set; }

    public string? PrelationIns2 { get; set; }

    public uint? PsubAccount2 { get; set; }

    public string? SendStmt { get; set; }

    public string? ChrgInterest { get; set; }

    public string? SendDunning { get; set; }

    public DateTime? NoticeDate { get; set; }

    public DateTime? ResponseDate { get; set; }

    public DateTime? ComplaintDate { get; set; }

    public uint? FailedAppt { get; set; }

    public string? WebPass { get; set; }

    public string? DdswebLinkUrl { get; set; }

    public string? AcceptEmail { get; set; }

    public string? AcceptText { get; set; }

    public string? MobileCarrier { get; set; }

    public int? DosePatientId { get; set; }

    public string? PreMed { get; set; }

    public DateTime? ChangedOn { get; set; }

    public uint OfficeId { get; set; }
}
