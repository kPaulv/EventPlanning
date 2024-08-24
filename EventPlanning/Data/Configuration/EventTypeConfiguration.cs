using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EventPlanning.Data.Entities;

namespace EventPlanning.Data.Configuration
{
    public class EventTypeConfiguration : IEntityTypeConfiguration<EventType>
    {
        public void Configure(EntityTypeBuilder<EventType> builder)
        {
            builder.HasData(
                new EventType
                {
                    Id = 1,
                    Name = "Sport",
                },
                new EventType
                {
                    Id = 2,
                    Name = "Music",
                }
            );
        }

    }
}
