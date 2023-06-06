using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "HelloWorld";
            return View();
        }

        public IActionResult Welcome(string name, int count)
        {
            ViewBag.Title = "Welcome";
            ViewBag.Name = name;
            ViewBag.Count = count;

            return View();
        }
    }
}
