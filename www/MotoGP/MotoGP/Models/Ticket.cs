namespace MotoGP.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        // FK Country
        public int CountryID { get; set; }
        // FK Race
        public int RaceID { get; set; }
        public string Number { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Paid { get; set; }
    }
}
