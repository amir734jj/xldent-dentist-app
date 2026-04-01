namespace Data.Models;

internal partial class Opcoesoper
{
    public int Operador { get; set; }

    public string? ColunasTratamentos { get; set; }

    public string? ApresentaPeriodontia { get; set; }

    public string? ApresentaOrtodontia { get; set; }

    public string ShowInk { get; set; } = null!;

    public byte? PerioExamOrder { get; set; }

    public int? PocketColor { get; set; }

    public int? RecessionColor { get; set; }

    public uint? Mgjcolor { get; set; }

    public int? PocketCompColor { get; set; }

    public int? RecessionCompColor { get; set; }

    public uint? MgjcompColor { get; set; }

    public int? FlagColor { get; set; }

    public byte? FlagValue { get; set; }

    public uint? InkColor { get; set; }

    public uint? InkWidth { get; set; }

    public string? AltPocketRecession { get; set; }

    public string? InitialAndTrt { get; set; }

    public string? ConditionsOn { get; set; }

    public string? MultiPost { get; set; }

    public string? ExamSeq1 { get; set; }

    public string? ExamSeq2 { get; set; }

    public string? ExamSeq3 { get; set; }

    public string? ExamSeq4 { get; set; }

    public string? PerioLoadPrevious { get; set; }

    public string? PerioAutoSeq { get; set; }

    public uint? VoiceDelay { get; set; }

    public string? ExamSeqDesc1 { get; set; }

    public string? ExamSeqDesc2 { get; set; }

    public string? ExamSeqDesc3 { get; set; }

    public string? ExamSeqDesc4 { get; set; }

    public string? AllResources { get; set; }

    public sbyte? NumericDisplay { get; set; }

    public string? ColorToothBmp { get; set; }

    public string? StatusTimes { get; set; }

    public uint OfficeId { get; set; }
}
