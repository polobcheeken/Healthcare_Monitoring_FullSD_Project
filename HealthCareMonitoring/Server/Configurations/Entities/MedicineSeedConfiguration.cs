using HealthCareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HealthCareMonitoring.Server.Configurations.Entities
{
    public class MedicineSeedConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.HasData(
            new Medicine
            {
                Id = 1,
                Name = "Paracetamol",
                Description = "Used for headaches",
                Type = "Tablet",
                MedicineFee = 5,
                ManufacturedDate = new DateTime(01 / 01 / 2024),
                ExpiryDate = new DateTime(01 / 01 / 2030),
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Medicine
            {
                Id = 2,
                Name = "Ibuprofen",
                Description = "Strong Painkiller, Only used when needed",
                Type = "Tablet",
                MedicineFee = 5.50,
                ManufacturedDate = new DateTime(01 / 01 / 2024),
                ExpiryDate = new DateTime(01 / 01 / 2030),
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Medicine
            {
                Id = 3,
                Name = "Xanax",
                Description = "Used to treat anxiety disorders",
                Type = "Pill",
                MedicineFee = 7.40,
                ManufacturedDate = new DateTime(01 / 01 / 2024),
                ExpiryDate = new DateTime(01 / 01 / 2030),
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Medicine
            {
                Id = 4,
                Name = "Benzonatate",
                Description = "Used to numb the throat and lungs to make cough reflex less active",
                Type = "Pill",
                MedicineFee = 4.30,
                ManufacturedDate = new DateTime(01 / 01 / 2024),
                ExpiryDate = new DateTime(01 / 01 / 2030),
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Medicine
            {
                Id = 5,
                Name = "Fluocinonide",
                Description = "Used to reduce swelling and itching of allergic reactions",
                Type = "Cream",
                MedicineFee = 13.20,
                ManufacturedDate = new DateTime(01 / 01 / 2024),
                ExpiryDate = new DateTime(01 / 01 / 2030),
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
