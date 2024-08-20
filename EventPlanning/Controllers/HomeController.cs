using EventPlanning.Data;
using EventPlanning.Models;
using EventPlanning.Models.Output;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using EventPlanning.Data.Entities;
using EventPlanning.Models.Output;

namespace EventPlanning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [Authorize]
        public IActionResult Index()
        {
            var events = _dbContext.Events.Include(e => e.Type).ThenInclude(t => t.Subtypes);

            if (events is null)
            {
                ViewData["Error"] = "No events found.";
                return View();
            }

            List<EventOutputDto> outputEvents = new List<EventOutputDto>();
            string subtypes = "";
            //foreach(Event e in events) 
            //{
                
            //    if (e.Type.Subtypes.Any())
            //    {
            //        foreach(EventSubtype s in e.Type.Subtypes)
            //        {
            //            subtypes += s.Name
            //        }
            //    }
            //    outputEvents.Add(new EventOutputDto()
            //    {
            //        Name = e.Name,
            //        Topic = e.Type.Name,
            //        Subtopic = string.Join(",", e.Type.Subtypes.)
            //    });
            //}

            if (User.IsInRole("Admin"))
            {
                return View(new EventsDisplayModel { IsAdminUser = true, Events = events.ToList()});
            }
            else
            {
                return View(new EventsDisplayModel { Events = events.ToList() });
            }
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}