using Microsoft.EntityFrameworkCore;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccessLayer.Context;

public class TravelaContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost;Initial Catalog=TravelaDb;User ID=SA;Password=Yasinyaman.43;Encrypt=False;TrustServerCertificate=True"
        );
        
    }

    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Category> Categories { get; set; }
}