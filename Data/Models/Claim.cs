namespace Data.Models;

internal partial class Claim
{
    public uint ClaimId { get; set; }

    public string InsSeq { get; set; } = null!;

    public uint PatientNo { get; set; }

    public string ClaimStatus { get; set; } = null!;

    public uint? InsuranceId { get; set; }

    public uint? PlanId { get; set; }

    public string? Method { get; set; }

    public string? Form { get; set; }

    public uint? DoctorId { get; set; }

    public string? BenAssign { get; set; }

    public string ClaimType { get; set; } = null!;

    public int CheckNo { get; set; }

    public string? Note { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public byte? TrtResultOf { get; set; }

    public DateTime? AccidentDate { get; set; }

    public string? AccidentState { get; set; }

    public string? Ortho { get; set; }

    public DateTime? OrthoDate { get; set; }

    public byte? OrthoMonths { get; set; }

    public string? Prosthesis { get; set; }

    public DateTime? ProsthesisDate { get; set; }

    public byte? Enclosures { get; set; }

    public DateTime? DateLastSrp { get; set; }

    public string? PrimAuth { get; set; }

    public string? SecAuth { get; set; }

    public DateTime? PrimAuthDate { get; set; }

    public DateTime? SecAuthDate { get; set; }

    public decimal? PrimAuthAmount { get; set; }

    public decimal? SecAuthAmount { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? LastSubmitDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal AdjAmount { get; set; }

    public decimal EstAdj { get; set; }

    public decimal? SubmitValue { get; set; }

    public decimal? EstValue { get; set; }

    public decimal? PatEstValue { get; set; }

    public decimal OtheInsValue { get; set; }

    public uint NumGeral { get; set; }

    public uint? NumOrc { get; set; }

    public string? PlaceOfTrt { get; set; }

    public string? Eratext { get; set; }

    public string? EracheckNo { get; set; }

    public uint? Eralink { get; set; }

    public string? UserNotes { get; set; }

    public string? LocName { get; set; }

    public string? LocAddress1 { get; set; }

    public string? LocAddress2 { get; set; }

    public string? LocCity { get; set; }

    public string? LocState { get; set; }

    public string? LocZip { get; set; }

    public string? LocNpi2 { get; set; }

    public string ProviderLocumTenens { get; set; } = null!;

    public int? AddInsLink { get; set; }

    public sbyte? MedClaimType { get; set; }

    public string? AddS2last { get; set; }

    public string? AddS2first { get; set; }

    public string? AddS2middle { get; set; }

    public string? AddS2groupNumber { get; set; }

    public string? AddS2employerName { get; set; }

    public string? AddI2name { get; set; }

    public DateTime? AddS2dob { get; set; }

    public string? AddS2sex { get; set; }

    public string? AddS2insCardId { get; set; }

    public string? AddI2address1 { get; set; }

    public string? AddI2address2 { get; set; }

    public string? AddI2city { get; set; }

    public string? AddI2state { get; set; }

    public string? AddI2zip { get; set; }

    public string? AddRelationIns { get; set; }

    public DateTime? AddIllnessDt { get; set; }

    public DateTime? AddSameIllnessDt { get; set; }

    public string? AddRefProvider { get; set; }

    public string? AddProvNpi { get; set; }

    public string? AddReserved1 { get; set; }

    public string? AddReserved2 { get; set; }

    public DateTime? AddNotWorkFrom { get; set; }

    public DateTime? AddNotWorkTo { get; set; }

    public DateTime? AddHospFrom { get; set; }

    public DateTime? AddHospTo { get; set; }

    public string? AddOutsideLab { get; set; }

    public decimal? AddLabCharges { get; set; }

    public string? AddMedicaid { get; set; }

    public string? AddMedicaidRef { get; set; }

    public string? AddPriorAuth { get; set; }

    public string? AddDiag1 { get; set; }

    public string? AddDiag2 { get; set; }

    public string? AddDiag3 { get; set; }

    public string? AddDiag4 { get; set; }

    public string? AddDiag5 { get; set; }

    public string? AddDiag6 { get; set; }

    public string? AddDiag7 { get; set; }

    public string? AddDiag8 { get; set; }

    public string? AddDiag9 { get; set; }

    public string? AddDiag10 { get; set; }

    public string? AddDiag11 { get; set; }

    public string? AddDiag12 { get; set; }

    public decimal? AddInsPaid { get; set; }

    public string? AddI2insType { get; set; }

    public string? AddAcceptAsgn { get; set; }

    public string? AddQual11B { get; set; }

    public string? AddQual14 { get; set; }

    public string? AddQual15 { get; set; }

    public string? AddQual17 { get; set; }

    public string? AddIcd { get; set; }

    public int? AttachmentId { get; set; }

    public string? CreateMethod { get; set; }

    public uint OfficeId { get; set; }
}
