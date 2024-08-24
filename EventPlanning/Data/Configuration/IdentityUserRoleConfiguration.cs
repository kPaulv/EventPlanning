using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPlanning.Data.Configuration
{
    public class IdentityUserRoleConfiguration : 
        IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1a13f68d-a1d0-4d23-869b-458c301ca761",
                    UserId = "1e345687-a24d-4344-a6c6-9443d048cdb9"
                }
            );
        }
    }
}
