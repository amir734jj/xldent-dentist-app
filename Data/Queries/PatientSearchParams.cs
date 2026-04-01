namespace Data.Queries;

/// <summary>
/// Search criteria for looking up a patient.
/// At least one property must be non-empty.
/// Phone is matched against home, mobile and work numbers.
/// Name is matched against first name, last name, and full-name fields.
/// </summary>
public sealed class PatientSearchParams
{
    /// <summary>Partial or full phone number (matched against home, mobile and work).</summary>
    public string? Phone { get; init; }

    /// <summary>Partial or full e-mail address.</summary>
    public string? Email { get; init; }

    /// <summary>Partial or full name (first, last, or combined).</summary>
    public string? Name { get; init; }

    /// <summary>Partial or full street address.</summary>
    public string? Address { get; init; }

    /// <summary>Exact appointment event UUID. When provided, results are limited to the patient owning this appointment.</summary>
    public string? EventId { get; init; }

    /// <summary>Inclusive start of the appointment date range filter (matches <c>apevents.StartDate</c>).</summary>
    public DateOnly? DateFrom { get; init; }

    /// <summary>Inclusive end of the appointment date range filter (matches <c>apevents.StartDate</c>).</summary>
    public DateOnly? DateTo { get; init; }
}
