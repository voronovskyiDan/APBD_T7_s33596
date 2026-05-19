using APBD_T7_s33596.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_T7_s33596.Infrastructure.DB.Configuration
{
    public class ComponentConfiguration : IEntityTypeConfiguration<Component>
    {
        public void Configure(EntityTypeBuilder<Component> builder)
        {
            builder.HasKey(e => e.Code);
            builder.Property(e => e.Code).HasColumnType("char(10)");

            builder.Property(e => e.Name).HasMaxLength(300);


            builder.HasData(
                new Component
                {
                    Code = "I9-14900K",
                    Name = "Intel i9 14900K",
                    Description = "High-end Intel CPU",
                    ComponentManufacturerId = 1,
                    ComponentTypeId = 1
                },
                new Component
                {
                    Code = "R9-7950X",
                    Name = "AMD Ryzen 9 7950X",
                    Description = "High-end AMD CPU",
                    ComponentManufacturerId = 2,
                    ComponentTypeId = 1
                },
                new Component
                {
                    Code = "RTX4090",
                    Name = "NVIDIA RTX 4090",
                    Description = "Top-tier GPU",
                    ComponentManufacturerId = 3,
                    ComponentTypeId = 2
                }
            );
        }
    }
}
