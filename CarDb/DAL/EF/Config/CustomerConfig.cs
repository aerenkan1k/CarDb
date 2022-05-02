using CarDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDb.DAL.EF.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
           builder.HasKey(builder => builder.CustomerId);

            builder.HasData(
               new Customer
               {
                   CustomerId = 1,
                   FirstName = "Ali",
                   LastName = "ÇİÇEK"
               },
               new Customer
               {
                   CustomerId = 2,
                   FirstName = "Abudder",
                   LastName= "KANIK"

               },
               new Customer
               {
                   CustomerId = 3,
                   FirstName = "Şahin",
                   LastName = "BAYINDIR"
               },
               new Customer
               {
                   CustomerId = 4,
                   FirstName = "Muhittin",
                   LastName = "KARABOĞA"
               }
           );
        }
    }
}
