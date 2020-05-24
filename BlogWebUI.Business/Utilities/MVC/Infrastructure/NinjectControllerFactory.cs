using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;

namespace BlogWebUI.Business.Utilities.MVC.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory(INinjectModule Module)
        {
            _kernel = new StandardKernel(Module);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController) _kernel.Get(controllerType);
        }
    }
}
