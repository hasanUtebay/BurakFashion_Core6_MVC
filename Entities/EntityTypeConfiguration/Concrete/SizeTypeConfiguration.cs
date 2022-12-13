using Entities.Concrete;
using Entities.EntityTypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.EntityTypeConfiguration.Concrete
{
    public class SizeTypeConfiguration : BaseEntityTypeConfiguration<Size>
    {
        public override void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property<string>(a => a.Name).HasMaxLength(20).IsRequired(true);
            builder.Property<string>(a => a.Symbol).HasMaxLength(10).IsRequired(true);

            base.Configure(builder);
        }
    }
}
