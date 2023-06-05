using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotoGP.Models;
using MotoGP.Data;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        private readonly GPContext _context;

        public InfoController(GPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListRaces()
        {
            var race = _context.Races.OrderBy(r => r.Date);

            ViewData["BannerNr"] = 0;

            return View(race.ToList());
        }

        public IActionResult BuildMap()
        {
            var race = _context.Races;

            ViewData["BannerNr"] = 0;

            return View(race);
        }

        public IActionResult ShowRace(int id)
        {
            var races = _context.Races.SingleOrDefault(r => r.RaceID == id);

            ViewData["BannerNr"] = 0;

            return View(races);
        }

        public IActionResult ListRiders()
        {
            var riders = _context.Riders.OrderBy(r => r.Number);

            ViewData["BannerNr"] = 1;

            return View(riders.ToList());
        }
    }
}
