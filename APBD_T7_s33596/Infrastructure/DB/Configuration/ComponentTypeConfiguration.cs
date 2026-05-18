using APBD_T7_s33596.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_T7_s33596.Infrastructure.DB.Configuration
{
    public class ComponentTypeConfiguration : IEntityTypeConfiguration<ComponentType>
    {
        public void Configure(EntityTypeBuilder<ComponentType> builder)
        {
            builder.Property(e => e.Abbreviation).HasMaxLength(30);
            builder.Property(e => e.Name).HasMaxLength(150);

            builder.HasMany(e => e.Components)
                   .WithOne(c => c.ComponentType)
                   .HasForeignKey(c => c.ComponentTypeId);

            builder.HasData(
                new ComponentType
                {
                    Id = 1,
                    Abbreviation = "CPU",
                    Name = "Processor"
                },
                new ComponentType
                {
                    Id = 2,
                    Abbreviation = "GPU",
                    Name = "Graphics Card"
                },
                new ComponentType
                {
                    Id = 3,
                    Abbreviation = "RAM",
                    Name = "Memory"
                }
            );
        }
    }
}
