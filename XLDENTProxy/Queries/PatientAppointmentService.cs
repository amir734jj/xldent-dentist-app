using XLDENTProxy.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Appointments;

namespace XLDENTProxy.Queries;

/// <summary>
/// Read-only service for searching patients and returning their
/// appointment history and insurance details.
///
/// Usage:
///   var results = await service.SearchAsync(new PatientSearchParams { Phone = "4141234567" });
/// </summary>
public sealed class PatientAppointmentService(DrDataContext context) : IPatientAppointmentService
{
    /// <summary>
    /// Searches patients by any combination of phone, email, name, or address.
    /// Returns each matching patient with their full appointment list and insurance plans.
    /// </summary>
    /// <param name="search">At least one search field must be provided.</param>
    /// <exception cref="ArgumentException">Thrown when all search fields are empty.</exception>
    public async Task<IReadOnlyList<PatientAppointmentResult>> SearchAsync(PatientSearchParams search)
    {
        // ── 1. Match patients ──────────────────────────────────────────────────
        var query = context.Pacientes.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(search.Phone))
        {
            var phone = search.Phone.Trim();
            query = query.Where(patient =>
                (patient.PtlfCasa != null && patient.PtlfCasa.Contains(phone)) ||
                (patient.Ptmovel  != null && patient.Ptmovel.Contains(phone))  ||
                (patient.PtlfEmpr != null && patient.PtlfEmpr.Contains(phone)));
        }

        if (!string.IsNullOrWhiteSpace(search.Email))
        {
            var email = search.Email.Trim();
            query = query.Where(patient => patient.Pemail != null && patient.Pemail.Contains(email));
        }

        if (!string.IsNullOrWhiteSpace(search.Name))
        {
            var name = search.Name.Trim();
            query = query.Where(patient =>
                (patient.Pfirst != null && patient.Pfirst.Contains(name)) ||
                (patient.Plast  != null && patient.Plast.Contains(name))  ||
                (patient.Pnome  != null && patient.Pnome.Contains(name)));
        }

        if (!string.IsNullOrWhiteSpace(search.Address))
        {
            var address = search.Address.Trim();
            query = query.Where(patient => patient.Pmorada != null && patient.Pmorada.Contains(address));
        }

        var patients = await query
            .Select(patient => new
            {
                patient.Pmecano,
                patient.Pfirst,
                patient.Plast,
                patient.Pnome,
                patient.PtlfCasa,
                patient.Ptmovel,
                patient.PtlfEmpr,
                patient.Pemail,
                patient.Pmorada,
                patient.Pcity,
                patient.Pstate,
                patient.Pzip,
                patient.Pcountry,
                patient.Pstatus,
                patient.Pnascim
            })
            .ToListAsync();

        if (patients.Count == 0)
        {
            return [];
        }

        var patientIds = patients.Select(patient => (int)patient.Pmecano).ToList();

        // ── 2. Load appointments (apevents ⟵ apdetail) ────────────────────────
        var apptQuery = context.Apevents.AsNoTracking()
            .Join(context.Apdetails.AsNoTracking(), apptEvent => apptEvent.EventId, apptDetail => apptDetail.EventId, (apptEvent, apptDetail) => new { apptEvent, apptDetail })
            .Where(joined => joined.apptDetail.Account != null && patientIds.Contains((int)joined.apptDetail.Account.Value));

        if (!string.IsNullOrWhiteSpace(search.EventId))
        {
            var eventId = search.EventId.Trim();
            apptQuery = apptQuery.Where(joined => joined.apptEvent.EventId == eventId);
        }

        if (search.DateFrom.HasValue)
        {
            var from = search.DateFrom.Value.ToDateTime(TimeOnly.MinValue);
            apptQuery = apptQuery.Where(joined => joined.apptEvent.StartDate >= from);
        }

        if (search.DateTo.HasValue)
        {
            var to = search.DateTo.Value.ToDateTime(TimeOnly.MaxValue);
            apptQuery = apptQuery.Where(joined => joined.apptEvent.StartDate <= to);
        }

        var appointments = await apptQuery
            .OrderByDescending(joined => joined.apptEvent.StartDate)
            .ThenByDescending(joined => joined.apptEvent.StartTime)
            .Select(joined => new
            {
                joined.apptEvent.EventId,
                PatientId     = (int)joined.apptDetail.Account!.Value,
                joined.apptEvent.StartDate,
                joined.apptEvent.StartTime,
                joined.apptEvent.EndDate,
                joined.apptEvent.EndTime,
                joined.apptEvent.Subject,
                joined.apptEvent.Status,
                joined.apptEvent.EventTypeName,
                joined.apptEvent.Notes,
                joined.apptEvent.Location,
                joined.apptEvent.AllDay,
                joined.apptEvent.Category,
                joined.apptEvent.ArrivedTime,
                joined.apptEvent.SeatedTime,
                joined.apptEvent.DismissedTime,
                joined.apptDetail.Duration,
                joined.apptDetail.ProviderId
            }).ToListAsync();

        // ── 2a. Batch-load provider names for the appointments found ───────────
        var providerIds = appointments
            .Where(appt => appt.ProviderId.HasValue)
            .Select(appt => appt.ProviderId!.Value)
            .Distinct()
            .ToList();

        var providerMap = providerIds.Count > 0
            ? await context.Medicos.AsNoTracking()
                .Where(medico => providerIds.Contains(medico.Codigo))
                .Select(medico => new { medico.Codigo, medico.Nome })
                .ToDictionaryAsync(medico => medico.Codigo, medico => medico.Nome)
            : [];

        // ── 3. Load insurance (pacins ⟵ entidades) ────────────────────────────
        var insurances = await context.Pacins.AsNoTracking()
            .GroupJoin(context.Entidades.AsNoTracking(), insurance => insurance.InsuranceId, insurer => (int)insurer.Ecod,
                (insurance, insurerGroup) => new { insurance, insurerGroup })
            .SelectMany(joined => joined.insurerGroup.DefaultIfEmpty(), (joined, insurer) => new { joined.insurance, insurer })
            .Where(joined => joined.insurance.Pac != null && patientIds.Contains(joined.insurance.Pac.Value))
            .Select(joined => new
            {
                joined.insurance.Pac,
                joined.insurance.GroupNumber,
                joined.insurance.InsCardId,
                joined.insurance.RelationIns,
                joined.insurance.EmployerName,
                InsuranceName   = joined.insurer != null ? joined.insurer.Enome    : null,
                InsuranceAbbrev = joined.insurer != null ? joined.insurer.Eabrevia : null
            }).ToListAsync();

        // ── 4. Map to results ──────────────────────────────────────────────────
        return patients.Select(patient =>
        {
            var patientId = (int)patient.Pmecano;

            return new PatientAppointmentResult
            {
                PatientId   = patientId,
                FirstName   = patient.Pfirst,
                LastName    = patient.Plast,
                FullName    = patient.Pnome,
                HomePhone   = patient.PtlfCasa,
                MobilePhone = patient.Ptmovel,
                WorkPhone   = patient.PtlfEmpr,
                Email       = patient.Pemail,
                Address     = patient.Pmorada,
                City        = patient.Pcity,
                State       = patient.Pstate,
                Zip         = patient.Pzip,
                Country     = patient.Pcountry,
                Status      = patient.Pstatus,
                DateOfBirth = patient.Pnascim,

                Appointments = appointments
                    .Where(appt => appt.PatientId == patientId)
                    .Select(appt => new AppointmentInfo
                    {
                        EventId       = appt.EventId,
                        StartDate     = appt.StartDate,
                        StartTime     = appt.StartTime,
                        EndDate       = appt.EndDate,
                        EndTime       = appt.EndTime,
                        Reason        = appt.Subject,
                        Status        = appt.Status,
                        EventType     = appt.EventTypeName,
                        Notes         = appt.Notes,
                        Location      = appt.Location,
                        AllDay        = appt.AllDay,
                        Category      = appt.Category,
                        ArrivedTime   = appt.ArrivedTime,
                        SeatedTime    = appt.SeatedTime,
                        DismissedTime = appt.DismissedTime,
                        Duration      = appt.Duration,
                        ProviderName  = appt.ProviderId.HasValue
                                        ? providerMap.GetValueOrDefault(appt.ProviderId.Value)
                                        : null
                    })
                    .ToList(),

                Insurances = insurances
                    .Where(insurance => insurance.Pac == patientId)
                    .Select(insurance => new InsuranceInfo
                    {
                        InsuranceName   = insurance.InsuranceName,
                        InsuranceAbbrev = insurance.InsuranceAbbrev,
                        GroupNumber     = insurance.GroupNumber,
                        CardId          = insurance.InsCardId,
                        Relation        = insurance.RelationIns,
                        EmployerName    = insurance.EmployerName
                    })
                    .ToList()
            };
        }).ToList();
    }

    /// <inheritdoc />
    public async Task<bool> CancelAppointmentAsync(string eventId)
    {
        var apptEvent = await context.Apevents
            .FirstOrDefaultAsync(e => e.EventId == eventId);

        if (apptEvent is null)
        {
            return false;
        }

        apptEvent.Status = AppointmentStatus.Cancelled;
        apptEvent.Done   = true;
        await context.SaveChangesAsync();
        return true;
    }
}
