using CarDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CarDb.DAL.EF.Config
{
    public class CarCustomerConfig : IEntityTypeConfiguration<CarCustomer>
    {
        public void Configure(EntityTypeBuilder<CarCustomer> builder)
        {
            builder.HasKey(cc => cc.CarCustomerId);

            builder
                .HasOne(cc => cc.Car)
                .WithMany(c => c.CarCustomers)
                .HasForeignKey(cc => cc.CarId);

            builder
                .HasOne(cc => cc.Customer)
                .WithMany(c => c.CarCustomers)
                .HasForeignKey(cc => cc.CustomerId);

            builder
                .HasData(new List<CarCustomer>
                {
                    new CarCustomer{ CarCustomerId=1, CarId=1, CustomerId = 1 },
                    new CarCustomer{ CarCustomerId=2, CarId=2, CustomerId = 2 },
                    new CarCustomer{ CarCustomerId=3, CarId=3, CustomerId = 3 },
                    new CarCustomer{ CarCustomerId=4, CarId=4, CustomerId = 4 }
                });
        }
    }
}
