using Duende.IdentityServer.EntityFramework.Options;
using HealthCareMonitoring.Server.Configurations.Entities;
using HealthCareMonitoring.Server.Models;
using HealthCareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace HealthCareMonitoring.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
		}
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Payment> Payments { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new HospitalSeedConfiguration());
			builder.ApplyConfiguration(new MedicineSeedConfiguration());
			builder.ApplyConfiguration(new RoleSeedConfiguration());
			builder.ApplyConfiguration(new UserRoleSeedConfiguration());
			builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new PatientSeedConfiguration());


            builder.Entity<Appointment>()
            .HasOne(a => a.Staff)
            .WithMany()
            .HasForeignKey(a => a.StaffId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Consultation>()
            .HasOne(a => a.Staff)
            .WithMany()
            .HasForeignKey(a => a.StaffId)
            .OnDelete(DeleteBehavior.Restrict);
        }
	}
}
