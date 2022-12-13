using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductSize
    {
        public int ProductID { get; set; }
       public Product Product { get; set; }

        public int SizeID { get; set; }
        public Size Size { get; set; }
    }
}
