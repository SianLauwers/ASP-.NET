﻿using Microsoft.AspNetCore.Mvc;
using MotoGP.Models;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListRaces()
        {
            ViewData["BannerNr"] = 0;

            return View();
        }

        public IActionResult BuildMap()
        {
            var races = new List<Race>
            {
                new Race { RaceID = 1, X = 517, Y = 19, Name = "Assen" },
                new Race { RaceID = 2, X = 859, Y = 249, Name = "Losail Circuit" },
                new Race { RaceID = 3, X = 194, Y = 428, Name = "Autódromo Termas de Río Hondo" }
            };

            ViewData["Races"] = races;
            ViewData["BannerNr"] = 0;

            return View();
        }
    }
}
