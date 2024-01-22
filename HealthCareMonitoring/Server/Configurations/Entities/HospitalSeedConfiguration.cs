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
