using DesignBookMyShow.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesignBookMyShow.Context
{
    public class BMSContext :DbContext
    {
        public BMSContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<City> City { get; set; }
        DbSet<Coupon> Coupon { get; set; }
        DbSet<Movie> Movie { get; set; }
        DbSet<Payment> Payment { get; set; }
        DbSet<Screen> Screen { get; set; }
        DbSet<Seat> Seat { get; set; }
        DbSet<Show> Show { get; set; }
        DbSet<ShowSeatMapping> ShowSeatMapping { get; set; }
        DbSet<Theatre> Theatre { get; set; }
        DbSet<Ticket> Ticket { get; set; }
        DbSet<User> User { get; set; }
    }
}
