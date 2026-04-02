namespace XLDENTProxy.Models;

internal partial class Benplan
{
    public uint PlanId { get; set; }

    public string PlanName { get; set; } = null!;

    public decimal PatDeductible { get; set; }

    public decimal MaxBenefit { get; set; }

    public string CalcFormula { get; set; } = null!;

    public string? Category { get; set; }

    public string? FromProc { get; set; }

    public string? ToProc { get; set; }

    public byte Percent { get; set; }

    public string Deductible { get; set; } = null!;

    public string? Ppo { get; set; }

    public string? Notes { get; set; }

    public uint OfficeId { get; set; }
}
