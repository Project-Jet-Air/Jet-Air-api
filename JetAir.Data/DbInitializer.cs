using JetAir.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace JetAir.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Name = "Shirt",
                    Description = "Ohio State shirt",
                    Brand = "Nike",
                    Price = 29.99M
                },
                new Item
                {
                    Id = 2,
                    Name = "Shorts",
                    Description = "Ohio State shorts",
                    Brand = "Nike",
                    Price = 44.00M
                }
            );
        }
    }
}