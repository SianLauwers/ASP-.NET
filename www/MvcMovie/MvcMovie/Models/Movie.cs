namespace MvcMovie.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int? Price { get; set; }
        public int RatingID { get; set; }

        public Rating? Rating { get; set; }
    }
}
