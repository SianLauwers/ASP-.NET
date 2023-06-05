using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Models.ViewModel
{
    public class ListTeamsRidersViewModel
    {
        public List<Rider> riders { get; set; }
        public List<Team> teams { get; set; }
        public int teamID { get; set; }
    }
}
