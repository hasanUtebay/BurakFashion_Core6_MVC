using Entities.Concrete;
using Entities.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDto> GetAllProduct();
        List<ProductDto> GetAllByCategoryId(int id);
        ProductDto GetProduct(int id);
    }
}
