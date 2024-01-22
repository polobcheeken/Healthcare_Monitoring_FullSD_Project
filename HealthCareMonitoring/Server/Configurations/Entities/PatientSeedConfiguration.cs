using HealthCareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HealthCareMonitoring.Server.Configurations.Entities
{
    public class PatientSeedConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
            new Patient
            {
                Id = 1,
                FirstName = "Micheal",
                LastName = "Tan",
                ContactNo = 12345678,
                EmailAddress = "michealtan@blazor.com",
                Username = "Mike",
                Password = "ilovekfc@123",
                DateYearJoined = DateTime.Now,
                DateOfBirth = new DateTime(2000, 01, 01),
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Patient
            {
                Id = 2,
                FirstName = "John",
                LastName = "Toh",
                ContactNo = 87654321,
                EmailAddress = "johntoh@blazor.com",
                Username = "Jonny",
                Password = "ihatekfc@321",
                DateYearJoined = DateTime.Now,
                DateOfBirth = new DateTime(2000, 12, 12),
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
             new Patient
             {
                 Id = 3,
                 FirstName = "Lily",
                 LastName = "Leow",
                 ContactNo = 13243546,
                 EmailAddress = "lilyleow@blazor.com",
                 Username = "Lil lee",
                 Password = "ilovemcs@123",
                 DateYearJoined = DateTime.Now,
                 DateOfBirth = new DateTime(1994, 03, 18),
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             },
              new Patient
              {
                  Id = 4,
                  FirstName = "Ryan",
                  LastName = "Tan",
                  ContactNo = 65432146,
                  EmailAddress = "ryantan@blazor.com",
                  Username = "Raiden",
                  Password = "ihatemcs@321",
                  DateYearJoined = DateTime.Now,
                  DateOfBirth = new DateTime(1988, 05, 25),
                  DateUpdated = DateTime.Now,
                  CreatedBy = "System",
                  UpdatedBy = "System"
              },
               new Patient
               {
                   Id = 5,
                   FirstName = "Nicole",
                   LastName = "Lim",
                   ContactNo = 84745671,
                   EmailAddress = "nicolelim@blazor.com",
                   Username = "Nicolas",
                   Password = "tysagoat@123",
                   DateYearJoined = DateTime.Now,
                   DateOfBirth = new DateTime(1977, 06, 09),
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               }
            );
        }
    }
}