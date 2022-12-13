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
    public class ColorTypeConfiguration : BaseEntityTypeConfiguration<Color>
    {
        public override void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property<string>(a => a.Name).HasMaxLength(20).IsRequired(true);
            builder.Property<string>(a => a.HexCode).HasMaxLength(7).IsRequired(true);

            base.Configure(builder);
        }
    }
}
