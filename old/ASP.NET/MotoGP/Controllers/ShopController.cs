using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotoGP.Data;
using MotoGP.Models;
using MotoGP.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {

        private readonly GPContext _context;

        public ShopController(GPContext context)
        {
            _context = context;
        }
        //GET
        public IActionResult OrderTicket()
        {
            int BannerNr = 3;
            ViewBag.BannerNr = BannerNr;

            ViewData["Countries"] =
                new SelectList(_context.Countries.OrderBy(c => c.Name), "CountryID", "Name");

            ViewData["Races"] =
                new SelectList(_context.Races.OrderBy(r => r.Name)).ToList();

            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OrderTicket(/*[Bind("CountryID, Number, RaceID, Name, Email, Address")]*/ Ticket ticket)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                _context.SaveChanges();
                return RedirectToAction("ConfirmOrder", new { id = ticket.TicketID });
            }

            return View(ticket);
        }
        
        // GET
        public IActionResult ConfirmOrder(int id)
        {
            int BannerNr = 3;
            ViewBag.BannerNr = BannerNr;

            var tickets = _context.Tickets.Include(t => t.Race).SingleOrDefault(t => t.TicketID == id);


            return View(tickets);
        }

        //GET
        public IActionResult ListTickets(int raceID = 0)
        {
            int BannerNr = 3;
            ViewBag.BannerNr = BannerNr;
            var ListTicketsVM = new ListTicketsViewModel();

            if (raceID != 0)
            {
                ListTicketsVM.Tickets = _context.Tickets.Include(c => c.Country).Where(t => t.RaceID == raceID).ToList();
            }
            else
            {
                ListTicketsVM.Tickets = _context.Tickets.Include(c => c.Country).ToList();
            }


            ListTicketsVM.Races = new SelectList(_context.Races.OrderBy(r => r.Name), "RaceID", "Name");
            ListTicketsVM.raceID = raceID;
            
            ListTicketsVM.Countries = new SelectList(_context.Countries.OrderBy(c => c.Name), "CountryID", "Name");

            return View(ListTicketsVM);
        }
        public IActionResult EditTicket(int id)
        {
            int BannerNr = 3;
            ViewBag.BannerNr = BannerNr;
            var ticket = _context.Tickets
                            .Include(t => t.Race)
                            .Include(t => t.Country)
                            .SingleOrDefault(m => m.TicketID == id);

            return View(ticket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTicket([Bind("TicketID, Paid")] Ticket ticket)
        {

            if (ModelState.IsValid)
            {
                _context.Tickets.Attach(ticket);
                _context.Entry(ticket).Property(t => t.Paid).IsModified = true;
                _context.SaveChanges();
            }

            return View(ticket);
        }
    }
}

