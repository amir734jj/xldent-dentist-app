using Shared.Appointments;

namespace XLDENTProxy.Interfaces;

public interface IPatientAppointmentService
{
    Task<IReadOnlyList<PatientAppointmentResult>> SearchAsync(PatientSearchParams search);

    /// <summary>
    /// Marks an appointment as cancelled by setting its <c>Status</c> to "Cancelled"
    /// and its <c>Done</c> flag to <c>true</c>.
    /// </summary>
    /// <param name="eventId">The UUID of the appointment to cancel.</param>
    /// <returns><c>true</c> if the appointment was found and cancelled; <c>false</c> if no matching appointment exists.</returns>
    Task<bool> CancelAppointmentAsync(string eventId);
}
