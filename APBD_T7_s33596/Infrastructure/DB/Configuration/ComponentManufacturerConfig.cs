using APBD_T7_s33596.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_T7_s33596.Infrastructure.DB.Configuration
{
    public class ComponentManufacturerConfig : IEntityTypeConfiguration<ComponentManufacturer>
    {
        public void Configure(EntityTypeBuilder<ComponentManufacturer> builder)
        {
            builder.Property(e => e.Attribute).HasMaxLength(30);
            builder.Property(e => e.Attribute).HasMaxLength(300);

            builder.HasMany(e => e.Components)
                .WithOne(c => c.ComponentManufacturer)
                .HasForeignKey(c => c.ComponentManufacturerId);

            builder.HasData(
                 new ComponentManufacturer
                 {
                     Id = 1,
                     Attribute = "Intel",
                     FullName = "Intel Corporation",
                     FoundationDate = new DateOnly(1968, 7, 18)
                 },
                 new ComponentManufacturer
                 {
                     Id = 2,
                     Attribute = "AMD",
                     FullName = "Advanced Micro Devices",
                     FoundationDate = new DateOnly(1969, 5, 1)
                 },
                 new ComponentManufacturer
                 {
                     Id = 3,
                     Attribute = "NVIDIA",
                     FullName = "NVIDIA Corporation",
                     FoundationDate = new DateOnly(1993, 4, 5)
                 }
             );
        }
    }
}
