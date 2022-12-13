using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.EntityTypeConfiguration.Concrete
{
    public class ProductSizeTypeConfiguration : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.HasKey(a => new { a.ProductID, a.SizeID });


            // Navgation Property
            builder.HasOne(a => a.Product).WithMany(a => a.ProductSizes).HasForeignKey(a => a.ProductID);
            builder.HasOne(a => a.Size).WithMany(a => a.ProductSizes).HasForeignKey(a => a.SizeID);

        }
    }
}
