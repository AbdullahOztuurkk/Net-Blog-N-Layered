using System.Data.Entity;
using BlogWebUI.Business.Utilities.MVC.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;
using BlogWebUI.Business.DependencyRevolvers.Ninject;
using BlogWebUI.DataAccess.Concrete.EntityFramework;
using log4net.Config;

namespace BlogWebUI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
        }
    }
}
