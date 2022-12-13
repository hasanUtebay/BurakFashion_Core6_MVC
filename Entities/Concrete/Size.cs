using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Size: BaseEntity
    {
        public Size()
        {
            ProductSizes=new List<ProductSize>();
        }
        public string Name { get; set; }
        public string Symbol { get; set; }

        // Navigation Property
        public List<ProductSize> ProductSizes { get; set; }

    }
}
