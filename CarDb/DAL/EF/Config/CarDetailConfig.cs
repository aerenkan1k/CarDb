using CarDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarDb.DAL.EF.Config
{
    public class CarDetailConfig : IEntityTypeConfiguration<CarDetail>
    {
        

        public void Configure(EntityTypeBuilder<CarDetail> builder)
        {
            builder.HasKey(cd => cd.CarDetailId);

            builder.HasOne(cd => cd.Car)
                .WithOne(c => c.CarDetail)
                .HasForeignKey<CarDetail>(cd => cd.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new CarDetail
                {
                    CarDetailId = 1,
                    CarId = 1,
                    Fuel = "Diesel",
                    EngineSize = 2_2,
                    Transmission = "Automatic",
                    Year = 2014 
                },
                new CarDetail
                {
                    CarDetailId = 2,
                    CarId = 2,
                    Fuel = "Diesel",
                    EngineSize = 1_6,
                    Transmission = "Manual",
                    Year = 2013
                },
                new CarDetail
                {
                    CarDetailId = 3,
                    CarId = 3,
                    Fuel = "Gasoline",
                    EngineSize = 1_6,
                    Transmission = "Manual",
                    Year = 1999
                },
                new CarDetail
                {
                    CarDetailId = 4,
                    CarId = 4,
                    Fuel = "Gasoline",
                    EngineSize = 1_4,
                    Transmission = "Manual",
                    Year = 2007

                }

            );
        }
    }
}
