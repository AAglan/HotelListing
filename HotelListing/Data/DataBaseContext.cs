using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }


        //Seed
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Egypt",
                    ShortName = "Egy"

                },
                new Country
                {
                    Id = 2,
                    Name = "England",
                    ShortName = "Eng"
                },
                new Country
                {
                    Id = 3,
                    Name = "Italy",
                    ShortName = "Ita"
                }

                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Grand",
                    Address = "Cairo",
                    Rating = 4.5,
                    CountryId = 1


                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "London",
                    Rating = 4,
                    CountryId = 2


                },
                new Hotel

                {
                    Id = 3,
                    Name = "Sandel Resort",
                    Address = "Milano",
                    Rating = 55,
                    CountryId = 3


                }
                );

        }
    }
}
