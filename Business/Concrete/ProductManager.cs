using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results.Abstract;
using Business.Utilities.Results.Concrete;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using Entities.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Create(AddProductDto addProductDto)
        {
            Product product = new Product()
            {
                Name = addProductDto.Name,
                Description = addProductDto.Description,
            };

            _productDal.Create(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(int id)
        {
            Product product = _productDal.Get(a => a.ID == id);
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<ProductDto>> GetAll()
        {
            List<ProductDto> products = _productDal.GetAllProduct();
            return new SuccessDataResult<List<ProductDto>>(products);
        }

        public IDataResult<List<ProductDto>> GetAllByCategoryId(int categoryId)
        {
            List<ProductDto> products = _productDal.GetAllByCategoryId(categoryId);
            return new SuccessDataResult<List<ProductDto>>(products);
        }

        public IDataResult<ProductDto> GetById(int id)
        {
            ProductDto product = _productDal.GetProduct(id);
            return new SuccessDataResult<ProductDto>(product);
        }

        public IResult Update(UpdateProductDto updateProductDto)
        {
           Product product = _productDal.Get(a=>a.ID== updateProductDto.ID);
            product.Name=updateProductDto.Name;
            product.Description=updateProductDto.Description;           
           // product.CategoryId=updateProductDto.CategoryId;

            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
