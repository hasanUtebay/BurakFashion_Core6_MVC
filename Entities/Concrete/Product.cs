using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductSizes = new List<ProductSize>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Navigation Property
        public int ColorID { get; set; }
        public Color Color { get; set; }
        public int MainCategoryID { get; set; }
        public MainCategory MainCategory { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }

        public List<ProductSize> ProductSizes { get; set; }
    }
}
