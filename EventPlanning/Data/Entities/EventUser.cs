namespace EventPlanning.Data.Entities
{
	public class EventUser
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string PhoneNumber { get; set; }
		public List<Event> Events { get; set; }
	}
}
