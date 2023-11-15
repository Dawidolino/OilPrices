using Microsoft.EntityFrameworkCore;

namespace OilPrices.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LocationModel> LocationModels { get; set; }
        public DbSet<FuelPriceModel> FuelPrices { get; set; }
    }
}
