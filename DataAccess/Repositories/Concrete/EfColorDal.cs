using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using Entities.Dtos.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ProjectContext>, IColorDal
    {
        public ColorDto GetById(int id)
        {
            using (ProjectContext projectContext = new ProjectContext())
            {
               var color =projectContext.Colors.FirstOrDefault(a=>a.ID== id);
                ColorDto colorDto= new ColorDto() { ID=color.ID,Name=color.Name,HexCode=color.HexCode};
                return colorDto;
            }
        }
    }
}
