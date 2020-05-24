using System.Collections.Generic;
using System.Linq;
using BlogWebUI.Business.Abstract;
using BlogWebUI.Business.Aspects.CacheAspects;
using BlogWebUI.Business.CrossCuttingCorners.Caching.Microsoft;
using BlogWebUI.DataAccess.Abstract;
using BlogWebUI.DataAccess.Concrete.EntityFramework;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void Add(Article article)
        {
            _articleDal.Add(article);
        }

        public void Delete(Article article)
        {
            _articleDal.Delete(article);
        }

        public List<Article> getArticlesByContent(string content)
        {
            return _articleDal.GetAll(m=>m.Content.Contains(content));
        }

        public List<Article> getArticlesByKeywords(string keyword)
        {
            return _articleDal.GetAll(m => m.Keywords.Contains(keyword));
        }

        public List<Article> GetArticlesByUserID(User user)
        {
            using (BlogContext db = new BlogContext())
            {
                return db.Articles.Where(z => z.UserID == user.UserID).ToList();
            }
        }

        public List<Article> getArticlesByUserName(string username)
        {
            using (BlogContext db=new BlogContext())
            {
                return db.Articles.Where(z => z.User.Name.Contains(username)).ToList();
            }
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Article> GetList()
        {
            return  _articleDal.GetAll();
        }

        public void Update(Article article)
        {
            _articleDal.Update(article);
        }
    }
}
