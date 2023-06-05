using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotoGP.Models;
using MotoGP.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotoGP.Models.ViewModel;

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

        public IActionResult SelectRace(int raceID = 0)
        {
            int BannerNr = 1;
            ViewBag.BannerNr = BannerNr;
            var SelectRaceVM = new SelectRaceViewModel();


            if (raceID != 0)
            {
                SelectRaceVM.races = _context.Races.Where(r => r.RaceID == raceID).ToList();
            }
            else
            {
                SelectRaceVM.races = _context.Races.ToList();
            }


            SelectRaceVM.Races = new SelectList(_context.Races.OrderBy(r => r.Name), "RaceID", "Name");
            SelectRaceVM.raceID = raceID;

            return View(SelectRaceVM);
        }

        public IActionResult ListTeams()
        {
            int BannerNr = 1;
            ViewBag.BannerNr = BannerNr;

            var riders = _context.Riders;
            var teams = _context.Teams;

            ViewData["Riders"] = riders.ToList();

            return View(teams);
        }

        public IActionResult ListTeamsRiders(int teamID)
        {
            int BannerNr = 1;
            ViewBag.BannerNr = BannerNr;
            var ListTeamsRidersVM = new ListTeamsRidersViewModel();


            if (teamID != 0)
            {
                ListTeamsRidersVM.teams = _context.Teams.ToList();
                ListTeamsRidersVM.riders = _context.Riders.Where(r => r.TeamID == teamID).ToList();
            }
            else
            {
                ListTeamsRidersVM.teams = _context.Teams.ToList();
                ListTeamsRidersVM.riders = _context.Riders.ToList();
            }

            return View(ListTeamsRidersVM);
        }

        /*public IActionResult ListTeamsRiders(int? teamID)
        {
            int BannerNr = 1;
            ViewBag.BannerNr = BannerNr;
            var teams = _context.Teams;

            if(teamID.HasValue )
            {
                var riders = _context.Riders.Where(r => r.TeamID == teamID);
                ViewData["Riders"] = riders.ToList();

            } else
            {
                ViewData["Riders"] = new List<Rider>();
            }


            return View(teams);
        }*/
    }
}