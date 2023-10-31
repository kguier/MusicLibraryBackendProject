using Microsoft.EntityFrameworkCore;
using MusicLibraryAPI.Models;

namespace MusicLibraryAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Waste My Time",
                    Artist = "The Crystal Casino Band",
                    Album = "Not About You",
                    ReleaseDate = new DateTime(2021,01,29),
                    Genre = "Alternative"
                },
                new Song
                {
                    Id = 2,
                    Title = "Francesca",
                    Artist = "Hozier",
                    Album = "Unreal Earth",
                    ReleaseDate = new DateTime(2023,05,19),
                    Genre = "Alternative/Indie"
                },
                 new Song
                 {
                     Id = 3,
                     Title = "Nothing Matters",
                     Artist = "The Last Dinner Party",
                     Album = "Nothing Matters",
                     ReleaseDate = new DateTime(2023,04,19),
                     Genre = "Alternative/Indie"

                 },
                 new Song
                 {
                     Id = 4,
                     Title = "Me and the Devil",
                     Artist = "Soap&Skin",
                     Album = "Sugarbread",
                     ReleaseDate = new DateTime(2013,03,11),
                     Genre = "Alternative/Indie",
                 },
                 new Song
                 {
                     Id = 5,
                     Title = "I Know Places",
                     Artist = "Taylor Swift",
                     Album = "1989",
                     ReleaseDate = new DateTime(2014,10,27),
                     Genre = "Electropop",
                 });
        }
    }
}
