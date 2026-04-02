using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Requests;

public sealed class SearchAppointmentsRequest : IAgentRequest
{
    /// <summary>Partial or full phone number (matched against home, mobile and work).</summary>
    public string? Phone { get; set; }

    /// <summary>Partial or full e-mail address.</summary>
    public string? Email { get; set; }

    /// <summary>Partial or full name (first, last, or combined).</summary>
    public string? Name { get; set; }

    /// <summary>Partial or full street address.</summary>
    public string? Address { get; set; }

    /// <summary>Exact appointment event UUID. Limits results to the patient owning this appointment.</summary>
    public string? EventId { get; set; }

    /// <summary>Inclusive start of the appointment date range (matches apevents.StartDate).</summary>
    public DateOnly? DateFrom { get; set; }

    /// <summary>Inclusive end of the appointment date range (matches apevents.StartDate).</summary>
    public DateOnly? DateTo { get; set; }

    public string RequestType => AgentRequestType.SearchAppointments;
}
