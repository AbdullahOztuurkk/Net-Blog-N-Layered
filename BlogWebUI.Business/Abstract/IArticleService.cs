using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.Business.Abstract
{
    public interface IArticleService
    {
        List<Article> GetList();
        List<Article> getArticlesByUserName(string username);
        List<Article> GetArticlesByUserID(User user);
        List<Article> getArticlesByContent(string content);
        List<Article> getArticlesByKeywords(string keyword);
        void Add(Article article);
        void Update(Article article);
        void Delete(Article article);
    }
}
