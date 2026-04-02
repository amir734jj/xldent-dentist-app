namespace Shared.Appointments;

/// <summary>Combined patient details, appointments, and insurance.</summary>
public sealed class PatientAppointmentResult
{
    /// <summary>Internal patient ID (PMecano).</summary>
    public int PatientId { get; init; }

    public string? FirstName { get; init; }
    public string? LastName { get; init; }

    /// <summary>Full name as stored in the legacy name field.</summary>
    public string? FullName { get; init; }

    public string? HomePhone { get; init; }
    public string? MobilePhone { get; init; }
    public string? WorkPhone { get; init; }
    public string? Email { get; init; }

    public string? Address { get; init; }
    public string? City { get; init; }
    public string? State { get; init; }
    public string? Zip { get; init; }
    public string? Country { get; init; }

    public string? Status { get; init; }
    public DateTime? DateOfBirth { get; init; }

    /// <summary>All appointments found for this patient.</summary>
    public IReadOnlyList<AppointmentInfo> Appointments { get; init; } = [];

    /// <summary>All active insurance plans for this patient.</summary>
    public IReadOnlyList<InsuranceInfo> Insurances { get; init; } = [];
}
