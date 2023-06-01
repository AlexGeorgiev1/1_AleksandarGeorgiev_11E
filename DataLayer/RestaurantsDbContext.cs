using BusinessLayer;
using System.Data.Entity;

namespace DataLayer
{
    public class RestaurantsDbContext : DbContext
    {
        public RestaurantsDbContext() : base("Data Source=DESKTOP-JQKUPGM;Initial Catalog=RestaurantDb;Integrated Security=True")
        {
            
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}