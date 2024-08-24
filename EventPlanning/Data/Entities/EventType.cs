using System.Diagnostics;

namespace EventPlanning.Data.Entities
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<EventSubtype> Subtypes { get; set; }
    }
}
