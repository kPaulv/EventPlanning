using System.Diagnostics;

namespace EventPlanning.Data.Entities
{
    public class EventSubtype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public EventType Type { get; set; }
    }
}
