using APBD_T7_s33596.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_T7_s33596.Infrastructure.Db.Configuration
{
    public class ComponentConfiguration : IEntityTypeConfiguration<Component>
    {
        public void Configure(EntityTypeBuilder<Component> builder)
        {
            builder.HasKey(e => e.Code);
            builder.Property(e => e.Code).HasColumnType("char(10)");

            builder.Property(e => e.Name).HasMaxLength(300);
        }
    }
}
