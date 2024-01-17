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
				StartDate = null,
				ExpiryDate = null,
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
				MedicineFee = 5,
				StartDate = null,
				ExpiryDate = null,
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
				MedicineFee = 5,
				StartDate = null,
				ExpiryDate = null,
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			}
			);
		}
	}
}
