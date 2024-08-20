using EventPlanning.Data;
using EventPlanning.Data.Entities;
using EventPlanning.Models.Input;
using System.Xml.Linq;

namespace EventPlanning.Services
{
	public interface IEventService
	{
		void CreateEvent(EventInputDto eventInputDto);
	}
	public class EventService : IEventService
	{
		private readonly ApplicationDbContext _dbContext;

		public EventService(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void CreateEvent(EventInputDto eventInputDto)
		{
			int typeId;

			List<EventSubtype> subtypes = new List<EventSubtype>();

			if (!string.IsNullOrEmpty(eventInputDto.Subtypes))
			{
				foreach (var subtype in eventInputDto.Subtypes.Split(","))
				{
					subtypes.Add(new EventSubtype { Name = subtype });
				}
			}

			EventType? type = _dbContext.EventTypes.Where(t => t.Name == eventInputDto.Type).FirstOrDefault();

			if(type is null)
			{
				type = new EventType 
				{ 
					Name = eventInputDto.Type,
					Subtypes = subtypes
				};
			}
			else
			{
				typeId = type.Id;
			}

			string? dresscode = eventInputDto?.Dresscode;
		    string? location = eventInputDto?.Location;
		    string? participants = eventInputDto.Participants;

			var e = new Event
			{
				Name = eventInputDto.Name,
				Type = type,
				Dresscode = dresscode,
				Participants = participants,
				Location = location,
			};
			_dbContext.Events.Add(e);
			_dbContext.SaveChangesAsync();
			Thread.Sleep(3000);
		}
	}
}
