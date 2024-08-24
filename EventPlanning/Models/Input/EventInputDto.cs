namespace EventPlanning.Models.Input
{
	public class EventInputDto
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Subtypes { get; set; }
		public string Dresscode { get; set; }
		public string Participants { get; set; }
		public string Location { get; set; }
		public int UserLimit { get; set; }
	}
}
