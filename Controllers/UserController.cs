using FitnessWG.Interfaces;
using FitnessWG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace FitnessWG.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepo _userRepo;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        // CREATE: Add a user profile

        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public async Task<IActionResult> Create(User model)
        {
            if (ModelState.IsValid)
            {
                await _userRepo.CreateUserAsync(model);
            }
            return View();
        }

        // READ: Display user profile

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ViewData["ActivePage"] = "Dashboard";
            var model = await _userRepo.UserDetailsAsync(id);

            if (model is null)
                return NotFound();

            return View(model);
        }
    }
}
