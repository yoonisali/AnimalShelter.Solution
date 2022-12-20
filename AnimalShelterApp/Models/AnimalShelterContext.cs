using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApp.Models
{
    public class AnimalShelterContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public AnimalShelterContext(DbContextOptions options) : base(options) { }
    }
}