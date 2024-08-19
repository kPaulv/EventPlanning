using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace EventPlanning.Data.Configuration
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var pwdHasher = new PasswordHasher<IdentityUser>();
            
            // Seeding admin user
            builder.HasData(
                new IdentityUser
                {
                    Id = "1e345687-a24d-4344-a6c6-9443d048cdb9", // primary key
                    UserName = "paulmaul",
                    NormalizedUserName = "PAULMAUL",
                    Email = "youradmin@mail.com",
                    NormalizedEmail = "YOURADMIN@MAIL.COM",
                    PasswordHash = pwdHasher.HashPassword(null, "Balab0b@")
                }
            );
        }
    }
}
