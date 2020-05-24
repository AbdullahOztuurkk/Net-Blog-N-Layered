using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.Business.Abstract;
using BlogWebUI.Business.Aspects.CacheAspects;
using BlogWebUI.Business.Aspects.LogAspects;
using BlogWebUI.Business.CrossCuttingCorners.Caching.Microsoft;
using BlogWebUI.Business.CrossCuttingCorners.Logging.Log4Net.Loggers;
using BlogWebUI.DataAccess.Abstract;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<User> GetList()
        {
            return _userDal.GetAll();
        }

        public List<User> getUsersByName(string Name)
        {
            return _userDal.GetAll(m => m.Name.Contains(Name));
        }

        public List<User> getUsersBySurname(string surname)
        {
            return _userDal.GetAll(m => m.Surname.Contains(surname));
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
