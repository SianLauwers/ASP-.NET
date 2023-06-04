using Microsoft.AspNetCore.Mvc;
using MotoGP.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MotoGP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Menu()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5); // Generate a random number between 1 and 4 (inclusive)

            ViewData["BannerNr"] = randomNumber;

            return View();
        }
    }
}