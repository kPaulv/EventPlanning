using EventPlanning.Data;
using EventPlanning.Data.Entities;
using EventPlanning.Models.Input;
using EventPlanning.Models.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventPlanning.Services
{
	public interface IEventService
	{
		Task CreateEventAsync(EventInputDto eventInputDto);
		Task<EventSignUpResponse> SignUpUserAsync(IdentityUser user, int eventId);
		Task<Event> GetEventWithUsersyIdAsync(int id);
	}
	public class EventService : IEventService
	{
		private readonly ApplicationDbContext _dbContext;

		public EventService(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Event> GetEventWithUsersyIdAsync(int id)
		{
			return 
				await _dbContext.Events.Include(e => e.Users)
										.Where(e => e.Id == id)
										.FirstOrDefaultAsync();
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

			if (type is null)
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

			var e = new Event
			{
				Name = eventInputDto.Name,
				Type = type,
				Dresscode = eventInputDto?.Dresscode,
				Participants = eventInputDto?.Participants,
				Location = eventInputDto?.Location,
				UserLimit = eventInputDto == null ? 0 : eventInputDto.UserLimit
			};
			_dbContext.Events.Add(e);
			var res = await _dbContext.SaveChangesAsync();
		}

		public async Task<EventSignUpResponse> SignUpUserAsync(IdentityUser user, int eventId)
		{

			var @event = await GetEventWithUsersyIdAsync(eventId);
			if (@event is null)
			{
				return new EventSignUpResponse
				{
					Result = EventSignUpResult.EventNotFound,
					Message = "Event not found."
				};
			}
			if (@event.Users != null && @event.Users.Any()
				&& @event.Users.Count() >= @event.UserLimit)
			{
				return new EventSignUpResponse
				{
					Result = EventSignUpResult.LimitExceeded,
					Message = "Limit of users per event exceeded."
				};
			}

			if (@event.Users == null)
				@event.Users = new List<EventUser>();

			if(@event.Users.Find(u => u.UserName == user.UserName) != null)
			{
                return new EventSignUpResponse
                {
                    Result = EventSignUpResult.SignUpFailed,
                    Message = "You are already signed for this event."
                };
            }

			@event.Users.Add(new EventUser
			{
				UserName = user.UserName,
				PhoneNumber = user.PhoneNumber
			});

			var res = await _dbContext.SaveChangesAsync();

			return res > 0 ?
				new EventSignUpResponse
				{
					Result = EventSignUpResult.Success,
					Message = "You signed up for event."
				}
				:
				new EventSignUpResponse
				{
					Result = EventSignUpResult.SignUpFailed,
					Message = "Failed to sign you up for event."
				};
		}


	}
}
