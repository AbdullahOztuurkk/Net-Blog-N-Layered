using BlogWebUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebUI.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        List<User> getUsersBySurname(string surname);
        List<User> getUsersByName(string Name);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
