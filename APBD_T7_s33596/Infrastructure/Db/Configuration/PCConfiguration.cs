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
        }
    }
}
