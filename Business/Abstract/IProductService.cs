using Business.Utilities.Results.Abstract;
using Entities.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Create(AddProductDto addProductDto);
        IResult Update(UpdateProductDto updateProductDto);
        IResult Delete(int id);
        IDataResult<ProductDto> GetById(int id);
        IDataResult<List<ProductDto>> GetAll();
        IDataResult<List<ProductDto>> GetAllByCategoryId(int id);
    }
}
