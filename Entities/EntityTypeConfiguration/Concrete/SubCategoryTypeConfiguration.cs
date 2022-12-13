using Entities.Concrete;
using Entities.EntityTypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.EntityTypeConfiguration.Concrete
{
    public class SubCategoryTypeConfiguration : BaseEntityTypeConfiguration<SubCategory>
    {
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.Property<string>(a => a.Name).HasMaxLength(20).IsRequired(true);
            base.Configure(builder);
        }
    }
}
