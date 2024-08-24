using EventPlanning.Data;
using EventPlanning.Models;
using EventPlanning.Models.Output;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using EventPlanning.Models.Input;
using EventPlanning.Services;

namespace EventPlanning.Controllers
{
	public class EventController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _dbContext;
		private readonly UserManager<IdentityUser> _userManager;
		private readonly IEventService _eventService;

		public EventController(ILogger<HomeController> logger,
			ApplicationDbContext dbContext, UserManager<IdentityUser> userManager,
			IEventService eventService)
		{
			_logger = logger;
			_dbContext = dbContext;
			_userManager = userManager;
			_eventService = eventService;
		}

		[Authorize]
		public IActionResult Index()
		{
			return View();
		}

		[Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(string name, string topic, string subtopics,
			string dresscode, string location, string participants, int limit)
		{
			EventInputDto input = new EventInputDto
			{
				Name = name,
				Type = topic,
				Subtypes = subtopics,
				Dresscode = dresscode, 
				Participants = participants,
				Location = location,
				UserLimit = limit
			};

			await _eventService.CreateEventAsync(input);

			return View("Index", true);
		}

		[Authorize]
		[HttpPost]
		public async Task<ActionResult> SignUp(int eventId, string EventName)
		{
			var user = await _userManager.GetUserAsync(User);
			//var selectedEvent = await _eventService.GetEventByIdAsync(eventId);

			var res = await _eventService.SignUpUserAsync(user, eventId);

			return View(res);
		}
	}
}