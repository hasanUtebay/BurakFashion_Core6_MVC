using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using Entities.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ProjectContext>, IProductDal
    {
        public ProductDto GetProduct(int id)
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
                //var result = from product in projectContext.Products
                //             join category in projectContext.Categories
                //             on product.CategoryId equals category.ID
                //             where (product.ID == id)
                //             select new ProductDto
                //             {
                //                 Name = product.Name,
                //                 CategoryName = category.Name,
                //                 Description = product.Description,
                //                 ID = product.ID,
                //             };
                //return result.FirstOrDefault();
                return default;
            }
        }

        public List<ProductDto> GetAllProduct()
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
                //var result = from product in projectContext.Products
                //             join category in projectContext.Categories
                //             on product.CategoryId equals category.ID
                //             select new ProductDto
                //             {
                //                 Name = product.Name,
                //                 CategoryName = category.Name,
                //                 Description = product.Description,
                //                 ID = product.ID,
                //             };
                //return result.ToList();
                return default;
            }
        }

        public List<ProductDto> GetAllByCategoryId(int categoryId)
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
                //var result = from product in projectContext.Products
                //             join category in projectContext.Categories
                //             on product.CategoryId equals category.ID
                //             where (product.CategoryId == categoryId)
                //             select new ProductDto
                //             {
                //                 Name = product.Name,
                //                 CategoryName = category.Name,
                //                 Description = product.Description,
                //                 ID = product.ID,
                //             };
                //return result.ToList();
                return default;
            }
        }
    }
}
