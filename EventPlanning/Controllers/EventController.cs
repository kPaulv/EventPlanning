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
        public ActionResult Create(string name, string topic, string subtopics,
			string dresscode, string location, string participants)
		{
			EventInputDto input = new EventInputDto
			{
				Name = name,
				Type = topic,
				Subtypes = subtopics,
				Dresscode = dresscode, 
				Participants = participants,
				Location = location,
			};

			_eventService.CreateEvent(input);

			return View("Index", true);
		}

    }
}