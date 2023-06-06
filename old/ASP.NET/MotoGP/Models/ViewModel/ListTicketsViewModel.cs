using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
