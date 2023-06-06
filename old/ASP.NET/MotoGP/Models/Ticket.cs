﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public int RaceID { get; set; }
        public Race Race { get; set; }
        public int Number { get; set; }

        public DateTime OrderDate { get; set; }

        public Boolean Paid { get; set; }


    }
}
