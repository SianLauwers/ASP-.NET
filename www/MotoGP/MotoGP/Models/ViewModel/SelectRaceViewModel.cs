using Microsoft.AspNetCore.Mvc.Rendering;

namespace MotoGP.Models.ViewModel
{
    public class SelectRaceViewModel
    {
        public List<Race> races { get; set; }
        public SelectList Races { get; set; }
        public int raceID { get; set; }

    }
}
