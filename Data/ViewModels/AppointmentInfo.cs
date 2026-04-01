namespace Data.ViewModels;

/// <summary>Full details for one appointment.</summary>
public sealed class AppointmentInfo
{
    /// <summary>Unique appointment identifier (UUID from apevents).</summary>
    public string EventId { get; init; } = string.Empty;

    /// <summary>Appointment start date.</summary>
    public DateTime? StartDate { get; init; }

    /// <summary>Appointment start time.</summary>
    public TimeSpan? StartTime { get; init; }

    /// <summary>Appointment end date.</summary>
    public DateTime? EndDate { get; init; }

    /// <summary>Appointment end time.</summary>
    public TimeSpan? EndTime { get; init; }

    /// <summary>Reason / title of the appointment (e.g. "Cleaning", "Implant").</summary>
    public string? Reason { get; init; }

    /// <summary>Appointment status (e.g. "Confirmed", "Cancelled").</summary>
    public string? Status { get; init; }

    /// <summary>Event type label (e.g. "Appt", "Block").</summary>
    public string? EventType { get; init; }

    /// <summary>Free-text notes attached to the appointment.</summary>
    public string? Notes { get; init; }

    /// <summary>Physical location / operatory where the appointment takes place.</summary>
    public string? Location { get; init; }

    /// <summary>True when the appointment occupies the entire day with no specific times.</summary>
    public bool? AllDay { get; init; }

    /// <summary>Category tag assigned to the appointment.</summary>
    public string? Category { get; init; }

    /// <summary>Scheduled duration (e.g. "60" minutes, stored as a string in the database).</summary>
    public string? Duration { get; init; }

    /// <summary>Full name of the provider (dentist / hygienist) assigned to the appointment.</summary>
    public string? ProviderName { get; init; }

    /// <summary>Time the patient arrived at the practice.</summary>
    public TimeSpan? ArrivedTime { get; init; }

    /// <summary>Time the patient was seated in the operatory.</summary>
    public TimeSpan? SeatedTime { get; init; }

    /// <summary>Time the patient was dismissed / left the practice.</summary>
    public TimeSpan? DismissedTime { get; init; }
}
