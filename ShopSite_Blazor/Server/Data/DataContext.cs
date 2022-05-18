using Microsoft.EntityFrameworkCore;
using ShopSite_Blazor.Shared;

namespace ShopSite_Blazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

            new Product
              {
                Id = 1,
                Title = "Sony PlayStation 5",
                Description = "Available at a lower price from other sellers that may not offer free Prime shipping.",
                ImageUrl = "https://m.media-amazon.com/images/I/311AAjeId7L._AC_.jpg",
                Price = 1795m,
             },
           new Product
           {
               Id = 2,
               Title = "FIFA 22 PSN",
               Description = "This product is intended for EU Region.  This CD Key will not work if your PS5 is not in EU region",
               ImageUrl = "https://www.cjs-cdkeys.com/product_images/p/21371.jpg",
               Price = 1200m,
           },
           new Product
           {
               Id = 3,
               Title = "FIFA 22 PSN",
               Description = "This product is intended for EU Region.  This CD Key will not work if your PS5 is not in EU region",
               ImageUrl = "https://www.cjs-cdkeys.com/product_images/p/21371.jpg",
               Price = 1200m,
           }
                );
        
        }

        public DbSet<Product> Products { get; set; }
    }
}
