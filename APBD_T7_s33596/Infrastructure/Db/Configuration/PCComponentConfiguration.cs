using APBD_T7_s33596.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_T7_s33596.Infrastructure.Db.Configuration
{
    public class PCComponentConfiguration : IEntityTypeConfiguration<PCComponent>
    {
        public void Configure(EntityTypeBuilder<PCComponent> builder)
        {
            builder.HasKey(e => new { e.PCId, e.ComponentCode });

            builder.HasOne(e => e.PC)
                    .WithMany(e => e.PCComponents)
                    .HasForeignKey(e => e.PCId);

            builder.HasOne(e => e.Component)
                   .WithMany(e => e.PCComponents)
                   .HasForeignKey(e => e.ComponentCode);
        }
    }
}
