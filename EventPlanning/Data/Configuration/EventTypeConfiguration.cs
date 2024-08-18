using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EventPlanning.Data.Entities;

namespace EventPlanning.Data.Configuration
{
    public class EventConfiguration
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData(
                new Event
                {
                    Id = 1,
                    Name = "Football Match",
                    TypeId = 1
                },
                new Event
                {
                    Id = 2,
                    Name = "Test Event",
                    TypeId = 2
                }
            );
        }

    }
}
