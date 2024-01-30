using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace DataAccess.Configurations.Entities
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1000,
                    Title = "Product 1",
                    Description = "It begins with this one",
                    ISBN = "84267913",
                    Author = "Smithovision",
                    ListPrice = 40,
                    Price = 40,
                    Price50 = 30,
                    Price100 = 20
                    

                },
                new Product
                {
                    Id = 2000,
                    Title = "Product 2",
                    Description = "Right hand man to the main man",
                    ISBN = "258687913",
                    Author = "Smithovision",
                    ListPrice = 40,
                    Price = 40,
                    Price50 = 30,
                    Price100 = 20
                },
                new Product
                {
                    Id = 3000,
                    Title = "Product 3",
                    Description = "The trio to the pack",
                    ISBN = "123456789",
                    Author = "Smithovision",
                    ListPrice = 40,
                    Price = 40,
                    Price50 = 30,
                    Price100 = 20
                },
                new Product
                {
                    Id = 4000,
                    Title = "Product 4",
                    Description = "A new product the fourth to be added",
                    ISBN = "789456123",
                    Author = "Smithovision",
                    ListPrice = 40,
                    Price = 40,
                    Price50 = 30,
                    Price100 = 20
                }
                );
        }
    }
}
