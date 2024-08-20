using EventPlanning.Data;
using EventPlanning.Models;
using EventPlanning.Models.Output;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using EventPlanning.Data.Entities;
using EventPlanning.Models.Output;
using Microsoft.AspNetCore.Identity;

namespace EventPlanning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, 
            ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _dbContext = dbContext;
            _userManager = userManager;
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

            if (User.IsInRole("Admin"))
            {
                return View(new EventsDisplayModel { UserRole = "Admin", Events = events.ToList()});
            }
            else
            {
                return View(new EventsDisplayModel { UserRole = "Guest", Events = events.ToList() });
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