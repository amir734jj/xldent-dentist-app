using Newtonsoft.Json;

namespace Shared.Appointments;

/// <summary>
/// Combined patient details, appointments, and insurance.
/// </summary>
public sealed class PatientAppointmentResult
{
    /// <summary>
    /// Internal patient ID (PMecano).
    /// </summary>
    [JsonIgnore]
    public int PatientId { get; init; }

    public string? FirstName { get; init; }
    public string? LastName { get; init; }

    /// <summary>
    /// Full name as stored in the legacy name field.
    /// </summary>
    public string? FullName { get; init; }

    public string? HomePhone { get; init; }
    public string? MobilePhone { get; init; }
    [JsonIgnore]
    public string? WorkPhone { get; init; }
    [JsonIgnore]
    public string? Email { get; init; }

    [JsonIgnore]
    public string? Address { get; init; }
    [JsonIgnore]
    public string? City { get; init; }
    [JsonIgnore]
    public string? State { get; init; }
    [JsonIgnore]
    public string? Zip { get; init; }
    [JsonIgnore]
    public string? Country { get; init; }

    [JsonIgnore]
    public string? Status { get; init; }
    [JsonIgnore]
    public DateTime? DateOfBirth { get; init; }

    /// <summary>
    /// All appointments found for this patient.
    /// </summary>
    public IReadOnlyList<AppointmentInfo> Appointments { get; init; } = [];

    /// <summary>
    /// All active insurance plans for this patient.
    /// </summary>
    [JsonIgnore]
    public IReadOnlyList<InsuranceInfo> Insurances { get; init; } = [];
}
