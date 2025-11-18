using CarRentalManagementSystem.Data;
using CarRentalManagementSystem.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CarRentalManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICarService _carService;
        private readonly IBookingService _bookingService;


        public AdminController(UserManager<IdentityUser> userManager,ICarService carService, IBookingService bookingService) 
        {
            _userManager = userManager;
            _carService = carService;
            _bookingService = bookingService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
