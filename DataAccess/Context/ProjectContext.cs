using Entities.Concrete;
using Entities.EntityTypeConfiguration.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BurakFashion;Trusted_Connection=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MainCategoryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ColorTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSizeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SizeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
