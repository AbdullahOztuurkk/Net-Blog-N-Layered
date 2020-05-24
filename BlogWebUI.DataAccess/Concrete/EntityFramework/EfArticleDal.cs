using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.DataAccess.Abstract;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal:EfEntityRepositoryBase<BlogContext,Article>,IArticleDal
    {
    }
}
