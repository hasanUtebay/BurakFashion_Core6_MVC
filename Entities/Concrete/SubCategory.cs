using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }

        // Navgation Property
        public List<Product> Products { get; set; }
    }
}
