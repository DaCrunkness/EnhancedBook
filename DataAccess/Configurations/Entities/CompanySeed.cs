using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.DataModels;

namespace DataAccess.Configurations.Entities
{
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = 1000,
                    Name = "Company A",
                    StreetAddress = "1234 ABCD",
                    City = "Shreveport",
                    State = "LA",
                    PostalCode = "71107",
                    PhoneNumber = "3182277317"
                },
                new Company
                {
                    Id = 2000,
                    Name = "Company B",
                    StreetAddress = "5678 EFGH",
                    City = "Monroe",
                    State = "LA",
                    PostalCode = "74618",
                    PhoneNumber = "3185127896"
                },
                new Company
                {
                    Id = 3000,
                    Name = "Company C",
                    StreetAddress = "0910 IJKL",
                    City = "Baton Rouge",
                    State = "LA",
                    PostalCode = "70810",
                    PhoneNumber = "2252467812"
                },
                new Company
                {
                    Id = 4000,
                    Name = "Company D",
                    StreetAddress = "1112 MNOP",
                    City = "New Orleans",
                    State = "LA",
                    PostalCode = "74598",
                    PhoneNumber = "5047896541"
                }
            );
        }
    }
}
