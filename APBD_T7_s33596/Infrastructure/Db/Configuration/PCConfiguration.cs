using APBD_T7_s33596.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_T7_s33596.Infrastructure.Db.Configuration
{
    public class PCConfiguration : IEntityTypeConfiguration<PC>
    {
        public void Configure(EntityTypeBuilder<PC> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.Weight).HasColumnType("float(5)");

            builder.HasData(
                new PC
                {
                    Id = 1,
                    Name = "Gaming Beast",
                    Weight = 12.5,
                    Warranty = 24,
                    CreatedAt = new DateTime(2025, 1, 1),
                    Stock = 5
                },
                new PC
                {
                    Id = 2,
                    Name = "Workstation Pro",
                    Weight = 10.2,
                    Warranty = 36,
                    CreatedAt = new DateTime(2025, 2, 10),
                    Stock = 3
                },
                new PC
                {
                    Id = 3,
                    Name = "Budget Build",
                    Weight = 8.0,
                    Warranty = 12,
                    CreatedAt = new DateTime(2025, 3, 15),
                    Stock = 10
                }
            );
        }
    }
}
