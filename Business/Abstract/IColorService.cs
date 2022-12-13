using Business.Utilities.Results.Abstract;
using Entities.Dtos.Color;
using Entities.Dtos.Product;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Create(AddColorDto addColorDto);
        IResult Update(UpdateColorDto updateColorDto);
        IResult Delete(int id);
        IDataResult<ColorDto> GetById(int id);
        IDataResult<List<ColorDto>> GetAll();
    }
}
