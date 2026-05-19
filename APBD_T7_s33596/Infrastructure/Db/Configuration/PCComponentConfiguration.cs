using APBD_T7_s33596.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_T7_s33596.Infrastructure.DB.Configuration
{
    public class PCComponentConfiguration : IEntityTypeConfiguration<PCComponent>
    {
        public void Configure(EntityTypeBuilder<PCComponent> builder)
        {
            builder.HasKey(e => new { e.PCId, e.ComponentCode });

            builder.HasOne(e => e.PC)
                    .WithMany(e => e.PCComponents)
                    .HasForeignKey(e => e.PCId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Component)
                   .WithMany(e => e.PCComponents)
                   .HasForeignKey(e => e.ComponentCode)
                   .OnDelete(DeleteBehavior.Cascade);


            builder.HasData(
                new PCComponent
                {
                    PCId = 1,
                    ComponentCode = "I9-14900K",
                    Amount = 1
                },
                new PCComponent
                {
                    PCId = 1,
                    ComponentCode = "R9-7950X",
                    Amount = 1
                },
                new PCComponent
                {
                    PCId = 2,
                    ComponentCode = "RTX4090",
                    Amount = 1
                }
            );
        }
    }
}
