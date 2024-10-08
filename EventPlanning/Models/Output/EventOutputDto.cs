﻿using System.ComponentModel.DataAnnotations;

namespace EventPlanning.Models.Output
{
	public class EventOutputDto
	{
		[Required]
		public string Name { get; set; }
		public string Topic { get; set; }
		public string Subtopic { get; set; }
		public string Dresscode { get; set; }
		public string Participants { get;set; }
		public string Location { get; set; }
	}
}
