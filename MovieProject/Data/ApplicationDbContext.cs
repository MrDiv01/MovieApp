using Microsoft.EntityFrameworkCore;
using MovieProject.Models;

namespace MovieProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public virtual DbSet<Movie> Movies { get; set; }
    }
}
