using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogWebUI.Business.Abstract;

namespace BlogWebUI.MVC.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: User
        public ActionResult Index()
        {
            var model = _userService.GetList();
            return View(model);
        }
    }
}