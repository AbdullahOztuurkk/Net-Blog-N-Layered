using System;
using BlogWebUI.Entities.Abstract;

namespace BlogWebUI.Entities.Concrete
{
    public class Article : IDatabaseEntity
    {
        public int ArticleID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string Keywords { get; set; }

        public virtual User User { get; set; }
    }
}
