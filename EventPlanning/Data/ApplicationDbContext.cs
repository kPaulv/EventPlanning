using EventPlanning.Data.Configuration;
using EventPlanning.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EventPlanning.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			/*if (!Events.Any())
            {
				modelBuilder.ApplyConfiguration(new EventConfiguration());
			}
            if (!EventTypes.Any())
            {
				modelBuilder.ApplyConfiguration(new EventTypeConfiguration());
			}
			if (!eventSubtypes.Any())
			{
				modelBuilder.ApplyConfiguration(new EventSubtypeConfiguration());
			}
			if (!base.Roles.Any())
			{
				modelBuilder.ApplyConfiguration(new IdentityRoleConfiguration());
			}
			if (!base.Users.Any())
			{
				modelBuilder.ApplyConfiguration(new IdentityUserConfiguration());
			}
			if (!base.UserRoles.Any())
			{
				modelBuilder.ApplyConfiguration(new IdentityUserRoleConfiguration());
			}*/
			modelBuilder.ApplyConfiguration(new EventConfiguration());
			modelBuilder.ApplyConfiguration(new EventTypeConfiguration());
			modelBuilder.ApplyConfiguration(new EventSubtypeConfiguration());
			modelBuilder.ApplyConfiguration(new IdentityRoleConfiguration());
			modelBuilder.ApplyConfiguration(new IdentityUserConfiguration());
			modelBuilder.ApplyConfiguration(new IdentityUserRoleConfiguration());
		}

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventSubtype> eventSubtypes { get; set; }
    }
}