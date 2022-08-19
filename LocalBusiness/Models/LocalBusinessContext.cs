using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options) { }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>().HasData(
        new Business { BusinessId = 1, Name = "FOMO Chicken", Type = "Food Cart", Genre = "Korean", Address="113 SE 28th Ave, Portland, OR 97214", Description = "Fried chicken with Korean or classic Southern flavors", Price = 2 }
      );
    }
  }
}
