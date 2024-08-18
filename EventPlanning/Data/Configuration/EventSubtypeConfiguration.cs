using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EventPlanning.Data.Entities;

namespace EventPlanning.Data.Configuration
{
    public class EventSubtypeConfiguration
    {
        public void Configure(EntityTypeBuilder<EventSubtype> builder)
        {
            builder.HasData(
                new EventSubtype
                {
                    Id = 1,
                    Name = "Rock",
                    TypeId = 2
                },
                new EventSubtype
                {
                    Id = 2,
                    Name = "Classical music",
                    TypeId = 2
                }
            );
        }

    }
}
