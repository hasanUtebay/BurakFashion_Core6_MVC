using Entities.Concrete;
using Entities.Dtos.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
        ColorDto GetById(int id);
    }
}
