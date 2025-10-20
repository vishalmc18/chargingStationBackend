using Microsoft.EntityFrameworkCore;
using chargingApi.Models;

namespace chargingApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ChargingStation> ChargingStations { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChargingStation>().HasData(
                new ChargingStation
                {
                    Id = 1,
                    StationName = "Pune 1",
                    LocationAddress = "Pune street one",
                    PinCode = "10001",
                    ConnectorType = "CCS",
                    Status = "Operational",
                    ImageUrl = "url/img1.jpg",
                    LocationLink = "https://maps.link/1"
                },
                new ChargingStation
                {
                    Id = 2,
                    StationName = "pune 2",
                    LocationAddress = "pune street 2",
                    PinCode = "20002",
                    ConnectorType = "Type 2",
                    Status = "Maintenance",
                    ImageUrl = "url/img2.jpg",
                    LocationLink = "https://maps.link/2"
                }
            );
        }
    }
}