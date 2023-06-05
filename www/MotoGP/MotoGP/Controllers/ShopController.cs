using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotoGP.Data;
using MotoGP.Models;
using MotoGP.Models.ViewModel;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {

        private readonly GPContext _context;

        public ShopController(GPContext context)
        {
            _context = context;
        }

        public IActionResult OrderTicket()
        {
            ViewData["BannerNr"] = 3;

            ViewData["Countries"] =
        new SelectList(_context.Countries.OrderBy(c => c.Name), "CountryID", "Name");

            ViewData["Races"] = new SelectList(_context.Races.OrderBy(r => r.Name), "RaceID", "Name").ToList();


            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OrderTicket(Ticket ticket)
        {

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            // Pass the ticket ID to the ConfirmOrder action
            return RedirectToAction("ConfirmOrder", "Shop", new { id = ticket.TicketID });


            ViewData["BannerNr"] = 3;
            return View(ticket);
        }


        // GET
        public IActionResult ConfirmOrder(int id)
        {
            ViewData["BannerNr"] = 3;

            // Retrieve the ticket from the database based on the provided ID
            var ticket = _context.Tickets.Include(t => t.Race).SingleOrDefault(t => t.TicketID == id);

            // Pass the ticket to the view
            return View(ticket);
        }

        //GET
        public IActionResult ListTickets(int raceID = 0)
        {
            ViewData["BannerNr"] = 3;
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
            ViewData["BannerNr"] = 3;
            var ticket = _context.Tickets
                            .Include(t => t.Race)
                            .Include(t => t.Country)
                            .SingleOrDefault(m => m.TicketID == id);

            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTicket(int id, Ticket ticket)
        {

            if (ModelState.IsValid)
            {
                _context.Tickets.Attach(ticket);
                _context.Entry(ticket).Property(t => t.Paid).IsModified = true;
                _context.SaveChanges();
            }

            ViewData["BannerNr"] = 3;
            return View(ticket);
        }


    }
}
