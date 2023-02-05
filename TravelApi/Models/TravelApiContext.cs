using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Destination>()
        .HasData(
            new Destination { DestinationId = 1, City = "Prague", Country = "Czech Republic", Review = "This place is awesome!", Rating = 5.0 },
            new Destination { DestinationId = 2, City = "Fukuoka", Country = "Japan", Review = "Very pretty!", Rating = 5.0 },
            new Destination { DestinationId = 3, City = "São Paulo", Country = "Brazil", Review = "Sunny!", Rating = 5.0 }
        );
    }
  }
}