namespace EventPlanning.Models.Output
{
    public class EventsDisplayModel
    {
        public string UserRole { get; set; } = "Guest";
        public List<Data.Entities.Event> Events { get; set; }
    }
}
