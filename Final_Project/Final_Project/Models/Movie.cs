namespace Final_Project.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Plot { get; set; }
        public DateTime DateCreated { get; set; }

        public DateOnly ReleaseDate { get; set; }
    }
}
