using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results.Abstract;
using Business.Utilities.Results.Concrete;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using Entities.Dtos.Color;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Create(AddColorDto addColorDto)
        {
            if(ColorAlreadyExist(addColorDto))
            {
                return new ErrorResult(Messages.ColorAlreadyExist);
            }
            Color Color = new Color()
            {
                Name = addColorDto.Name,
                HexCode = addColorDto.HexCode,
            };

            _colorDal.Create(Color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(int id)
        {
            Color Color = _colorDal.Get(a => a.ID == id);
            _colorDal.Delete(Color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<ColorDto>> GetAll()
        {
            List<ColorDto> Colors = (List<ColorDto>)_colorDal.GetAll().Select(x=> new ColorDto { ID=x.ID,Name=x.Name,HexCode=x.HexCode}).ToList();

            return new SuccessDataResult<List<ColorDto>>(Colors);
        }

        public IDataResult<ColorDto> GetById(int id)
        {
            ColorDto Color =_colorDal.GetById(id);
            return new SuccessDataResult<ColorDto>(Color);
        }

        public IResult Update(UpdateColorDto updateColorDto)
        {
            Color Color = _colorDal.Get(a => a.ID == updateColorDto.ID);
            Color.Name = updateColorDto.Name;
            Color.HexCode = updateColorDto.HexCode;
            _colorDal.Update(Color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        // Business Rules
        public bool ColorAlreadyExist(AddColorDto dto)
        {
            var colors = _colorDal.GetAll();
            if (colors.Any(a => a.Name == dto.Name) | colors.Any(a => a.HexCode == dto.HexCode))
            {
                return true;
            }
            return false;
        }
    }
}
