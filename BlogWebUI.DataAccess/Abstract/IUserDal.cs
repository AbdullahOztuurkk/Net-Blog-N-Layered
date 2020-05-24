using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {

    }
}
