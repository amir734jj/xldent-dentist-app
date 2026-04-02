namespace XLDENTProxy.ViewModels;

/// <summary>Insurance plan associated with a patient.</summary>
public sealed class InsuranceInfo
{
    /// <summary>Full name of the insurance company.</summary>
    public string? InsuranceName { get; init; }

    /// <summary>Abbreviation or short code for the insurer.</summary>
    public string? InsuranceAbbrev { get; init; }

    /// <summary>Group / plan number.</summary>
    public string? GroupNumber { get; init; }

    /// <summary>Insurance card / member ID.</summary>
    public string? CardId { get; init; }

    /// <summary>Patient's relationship to the policy holder (Self, Spouse, Child, Other).</summary>
    public string? Relation { get; init; }

    /// <summary>Employer through which the plan is provided.</summary>
    public string? EmployerName { get; init; }
}