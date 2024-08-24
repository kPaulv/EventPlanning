using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPlanning.Data.Configuration
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole 
                { 
                    Id = "1a13f68d-a1d0-4d23-869b-458c301ca761", 
                    Name = "Admin", 
                    NormalizedName = "ADMIN" 
                },
                new IdentityRole 
                { 
                    Id = "2a14f69d-a2d1-5d34-970b-569c412ca872",
					Name = "Guest", 
                    NormalizedName = "GUEST" 
                }
            );
        }
    }
}
