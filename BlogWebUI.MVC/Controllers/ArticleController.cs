using System.Linq;
using System.Web.Mvc;
using BlogWebUI.Business.Abstract;
using BlogWebUI.DataAccess.Concrete.EntityFramework;

namespace BlogWebUI.MVC.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        private IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public ActionResult Index()
        {
            using (BlogContext db=new BlogContext())
            {
                var model = db.Articles.Include("User").ToList();
                return View(model);
            }
        }
    }
}