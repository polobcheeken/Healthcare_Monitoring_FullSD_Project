using HealthCareMonitoring.Server.Repository;
using HealthCareMonitoring.Shared.Domain;
using System.Drawing;

namespace HealthCareMonitoring.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Appointment> Appointments { get; }
        IGenericRepository<Consultation> Consultations { get; }
        IGenericRepository<Hospital> Hospitals { get; }
        IGenericRepository<Medicine> Medicines { get; }
        IGenericRepository<Patient> Patients { get; }
        IGenericRepository<Prescription> Prescriptions { get; }
        IGenericRepository<PrescriptionItem> PrescriptionItems { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Payment> Payments { get; }
    }
}
