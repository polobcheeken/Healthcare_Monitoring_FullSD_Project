using Duende.IdentityServer.EntityFramework.Options;
using HealthCareMonitoring.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HealthCareMonitoring.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
<<<<<<< HEAD
=======

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Payment> Payments { get; set; }
>>>>>>> 5eb0dad489109e8062baaa3f6fb89913533d6b0d
    }
}
