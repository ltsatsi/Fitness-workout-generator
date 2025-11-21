using System.Diagnostics;
using FitnessWG.Data;
using FitnessWG.Interfaces;
using FitnessWG.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessWG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SQLiteDBContext _context;
        private readonly IDBInitializer _seedDb;

        public HomeController(ILogger<HomeController> logger, SQLiteDBContext context, IDBInitializer seedDb)
        {
            _logger = logger;
            _seedDb = seedDb;
            _context = context;
        }

        public IActionResult SeedDatabase()
        {
            // Create a Database folder dynamically
            string dbDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Database");

            if (!Directory.Exists(dbDirectory))
            {
                Directory.CreateDirectory(dbDirectory);
            }

            _seedDb.Initialize(_context);
            ViewBag.SeedFeedBack = "Database successfully created. Check Database folder.";
            return View();
        }

        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Home";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["ActivePage"] = "Privacy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
