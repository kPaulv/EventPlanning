using EventPlanning.Data;
using EventPlanning.Data.Entities;
using EventPlanning.Models.Input;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EventPlanning.Services
{
	public interface IEventService
	{
		Task CreateEventAsync(EventInputDto eventInputDto);
		Task RegisterUserAsync(IdentityUser user, Event @event);
	}
	public class EventService : IEventService
	{
		private readonly ApplicationDbContext _dbContext;

		public EventService(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task CreateEventAsync(EventInputDto eventInputDto)
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
			var res = await _dbContext.SaveChangesAsync();
			//Thread.Sleep(3000);
		}

		public async Task RegisterUserAsync(IdentityUser user, Event selectedEvent) {

			await Task.Run(() => { });
		}


	}
}
