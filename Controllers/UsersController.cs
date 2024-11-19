using CarRentalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly CarRentalSystemDbContext _context;

        public UserController(CarRentalSystemDbContext context)
        {
            _context = context;
        }

        // Sign Up Page (GET)
        public IActionResult SignUp()
        {
            ViewData["Countries"] = new SelectList(_context.Countries, "CountryId", "Name");
            return View();
        }

        // Handle User Registration (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                // Check if the email already exists
                var emailExists = await _context.Users.AnyAsync(u => u.Email == user.Email);
                if (emailExists)
                {
                    ModelState.AddModelError("Email", "Email is already taken.");
                    return View(user);
                }

                // Save the user (without password encryption for now)
                user.Password = user.Password;  // Simply use the entered password directly
                user.ConfirmPassword = user.Password;

                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SignIn)); // Redirect to SignIn page after successful registration
            }

            // Repopulate the countries dropdown if the form fails
            ViewData["Countries"] = new SelectList(_context.Countries, "CountryId", "Name");
            return View(user);
        }

        // Sign In Page (GET)
        public IActionResult SignIn()
        {
            return View();
        }

        // Handle User Sign In (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null || user.Password != password) // Compare plain text passwords
            {
                ViewData["ErrorMessage"] = "Invalid login attempt.";
                return View();
            }

            // Create session or authentication cookie (for now, we redirect to the MainPage)
            return RedirectToAction(nameof(MainPage));
        }

        // Main Page after sign-in
        public IActionResult MainPage()
        {
            var availableCars = _context.Cars.Where(c => c.IsAvailable).ToList();
            return View(availableCars);
        }
    }
}
