using EventPlanning.Data.Configuration;
using EventPlanning.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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

            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new EventTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EventSubtypeConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityRoleConfiguration());
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventSubtype> eventSubtypes { get; set; }
    }
}