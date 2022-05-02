using CarDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDb.DAL.EF.Config
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.CarId);



            builder.HasOne(c => c.Brand)
                .WithMany(b => b.Cars)
                .HasForeignKey(b => b.BrandId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Car { CarId = 1, ModelName = "Mercedes-Benz E220 CDI", BrandId = 1, Price = 720000},
                new Car { CarId = 2, ModelName = "Volkswagen Jetta 1.6 TDI", BrandId = 2, Price = 200000},
                new Car { CarId = 3, ModelName = "Renault Brodway", BrandId = 3, Price = 50000},
                new Car { CarId = 4, ModelName = "Honda City", BrandId = 4, Price = 95000 }
            );
        }

    }
}
