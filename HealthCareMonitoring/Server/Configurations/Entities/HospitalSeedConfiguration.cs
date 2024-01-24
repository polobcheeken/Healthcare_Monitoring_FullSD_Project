using HealthCareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HealthCareMonitoring.Server.Configurations.Entities
{
    public class HospitalSeedConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasData(
            new Hospital
            {
                Id = 1,
                Name = "KK Women’s and Children’s Hospital",
                Address = "100 Bukit Timah Road",
                Description = "Specialising in obstetrics, gynaecology, neonatology and paediatrics",
                PostalCode = "Singapore 229899",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Hospital
            {
                Id = 2,
                Name = "Singapore General Hospital",
                Address = "Bukit Merah",
                Description = "Larget tertiary hospital and ranked among the world's best",
                PostalCode = "Singapore 169608",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Hospital
            {
                Id = 3,
                Name = "Gleneagles Hospital",
                Address = "6A Napier Road",
                Description = "Private institution with comprehensive range of medical care",
                PostalCode = "Singapore 258500",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Hospital
            {
                Id = 4,
                Name = "Changi General Hospital",
                Address = "2 Simei Street 3",
                Description = "1000-bed hospital, always alwayble for emergencies",
                PostalCode = "Singapore 529889",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Hospital
            {
                Id = 5,
                Name = "Mount Elizabeth Hospital",
                Address = "3 Mount Elizabeth",
                Description = "Singapore's best doctors and provides exceptional personalised medical services",
                PostalCode = "Singapore 228510",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
