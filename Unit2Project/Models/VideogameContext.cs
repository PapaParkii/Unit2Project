using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Unit2Project.Models
{
    public class VideogameContext : DbContext
    {
        public VideogameContext(DbContextOptions<VideogameContext> options)
            : base(options)
        { }
        public DbSet<Videogame> Videogames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Establish base database
            modelBuilder.Entity<Videogame>().HasData(
                new Videogame
                {
                    VideogameID = 1,
                    Name = "Modern Warfare 2",
                    YearReleased = 2009,
                    Rating = 5
                },
                new Videogame
                {
                    VideogameID = 2,
                    Name = "Wonder Woman",
                    YearReleased = 2017,
                    Rating = 3
                },
                new Videogame
                {
                    VideogameID = 3,
                    Name = "Moonstruck",
                    YearReleased = 1988,
                    Rating = 4
                }
            );
        }
    }
}
