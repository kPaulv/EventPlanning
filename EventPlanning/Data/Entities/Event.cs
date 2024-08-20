using System.Diagnostics;

namespace EventPlanning.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public EventType? Type { get; set; }
        public string? Dresscode { get; set; }
        public string? Location { get; set; }
        public string? Participants { get; set; }
    }
}
