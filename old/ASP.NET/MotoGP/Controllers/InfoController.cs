using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MotoGP.Models;
using MotoGP.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotoGP.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {

        private readonly GPContext _context;

        public InfoController(GPContext context)
        {
            _context = context;
        }

        public IActionResult BuildMap() {
            int BannerNr = 0;
            ViewBag.BannerNr = BannerNr;

            var races = _context.Races;

            return View(races);
        }

        public IActionResult ListRaces()
        {
            int BannerNr = 0;
            ViewBag.BannerNr = BannerNr;

            var races = _context.Races.OrderBy(r => r.Date);

            return View(races);
        }

        public IActionResult ShowRace(int id)
        {
            int BannerNr = 0;
            ViewBag.BannerNr = BannerNr;

            var races = _context.Races.SingleOrDefault(r => r.RaceID == id);

            return View(races);
        }
        public IActionResult ListRiders()
        {
            int BannerNr = 1;
            ViewBag.BannerNr = BannerNr;

            var riders = _context.Riders.OrderBy(r => r.Number);
            

            return View(riders);
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
                ListTeamsRidersVM.riders = _context.Riders.Where(r => r.TeamID ==teamID).ToList();
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
