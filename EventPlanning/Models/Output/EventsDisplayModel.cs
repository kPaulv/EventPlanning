namespace EventPlanning.Models.Output
{
    public class EventsDisplayModel
    {
        public bool IsAdminUser { get; set; } = false;
        public List<Data.Entities.Event> Events { get; set; }
    }
}
