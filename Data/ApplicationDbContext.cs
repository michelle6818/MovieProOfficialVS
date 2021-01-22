using Microsoft.EntityFrameworkCore;
using MovieProOfficial.Models;

namespace MovieProOfficial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Studio> Studios { get; set; }
    }
}
