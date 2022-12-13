using Entities.Concrete;
using Entities.EntityTypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EntityTypeConfiguration.Concrete
{
    public class ProductTypeConfiguration : BaseEntityTypeConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property<string>(a => a.Name).HasMaxLength(25).IsRequired(true);
            builder.Property<string>(a => a.Description).HasMaxLength(25).IsRequired(false);
            builder.Property<decimal>(a => a.Price).HasPrecision(5,2).IsRequired(true);

            builder.Property<int>(a => a.ColorID).IsRequired(true);
            builder.Property<int>(a => a.MainCategoryID).IsRequired(true);
            builder.Property<int>(a => a.SubCategoryID).IsRequired(true);
                       
            // Navgation Property
            builder.HasOne(a => a.Color).WithMany(a => a.Products).HasForeignKey(a => a.ColorID);
            builder.HasOne(a => a.MainCategory).WithMany(a => a.Products).HasForeignKey(a => a.MainCategoryID);
            builder.HasOne(a => a.SubCategory).WithMany(a => a.Products).HasForeignKey(a => a.SubCategoryID);

            base.Configure(builder);
        }
    }
}
