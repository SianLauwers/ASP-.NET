using Microsoft.AspNetCore.Mvc.Rendering;

namespace MotoGP.Models.ViewModel
{
    public class ListTicketsViewModel
    {
        public List<Ticket> Tickets { get; set; }
        public SelectList Races { get; set; }
        public SelectList Countries { get; set; }
        public int raceID { get; set; }

    }
}
