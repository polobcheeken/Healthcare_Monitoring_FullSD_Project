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
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			},
			new Hospital
			{
				Id = 2,
				Name = "Singapore General Hospital",
				Address = "Outram Road",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			},
			new Hospital
			{
				Id = 3,
				Name = "Gleneagles Hospital",
				Address = "Napier Road",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			}
			);
		}
	}
}
