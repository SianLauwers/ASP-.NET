namespace MotoGP.Models
{
    public class Rider
    {
        public int RiderID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        // FK Country
        public int CountryID { get; set; }
        // FK Team
        public int TeamID { get; set; }
        public string Bike { get; set; }
        public int Number { get; set; }
    }
}
