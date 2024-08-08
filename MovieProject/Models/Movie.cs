using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    public class Movie:BaseEntity
    {
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
