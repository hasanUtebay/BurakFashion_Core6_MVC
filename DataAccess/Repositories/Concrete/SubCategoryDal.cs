using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class SubCategoryDal:EfEntityRepositoryBase<SubCategory,ProjectContext>,ISubCategoryDal
    {
    }
}
