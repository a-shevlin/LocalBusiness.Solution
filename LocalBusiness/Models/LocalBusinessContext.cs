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
        new Business { BusinessId = 1, Name = "FOMO Chicken", Type = "Food Cart", Genre = "Korean", Address="113 SE 28th Ave, Portland, OR 97214", Description = "Fried Chicken Food Cart devoted to Korean and American Southern Flavors", Price = 2 },
        new Business { BusinessId = 2, Name= "Arium Botanicals", Type = "Shop", Genre = "Plant Nursery", Address = "2046 NE Martin Luther King Jr Blvd, Portland, OR 97212", Description = "A LGBTQ owned plant store specializing in rare plants.", Price = 3 },
        new Business { BusinessId = 3, Name= "Ole Ole", Type = "Restaurant", Genre = "Mexican", Address = "2137 E Burnside St, Portland, OR 97214", Description = "A compact family owned mexican restaurant.", Price = 1 },
        new Business { BusinessId = 4, Name= "Tinys Coffee", Type = "Coffee Shop", Genre = "Cafe", Address = "2031 NE Martin Luther King Jr Blvd, Portland, OR 97212", Description = "Coffee shop serving fair trade locally roasted coffee beans.", Price = 1 }
      );
    }
  }
}
