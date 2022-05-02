using CarDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDb.DAL.EF.Config
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.BrandId);

            builder.Property(b => b.BrandName)
                .HasMaxLength(200);

            builder.HasData(
               new Brand { BrandId = 1, BrandName = "Mercedes-Benz", Country ="Germany"},
               new Brand { BrandId = 2, BrandName = "Volkswagen", Country = "Germany" },
               new Brand { BrandId = 3, BrandName = "Renault", Country= "France" },
               new Brand { BrandId = 4, BrandName = "Honda", Country = "Japan" });
        }
    }
}
