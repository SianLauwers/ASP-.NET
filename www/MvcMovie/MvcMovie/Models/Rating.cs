namespace MvcMovie.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ICollection<Movie>? Movies { get; set; }
    }
}
