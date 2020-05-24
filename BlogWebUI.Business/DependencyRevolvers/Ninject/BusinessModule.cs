using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.Business.Abstract;
using BlogWebUI.Business.Concrete;
using BlogWebUI.DataAccess.Abstract;
using BlogWebUI.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace BlogWebUI.Business.DependencyRevolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IArticleDal>().To<EfArticleDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IArticleService>().To<ArticleManager>().InSingletonScope();

        }
    }
}
