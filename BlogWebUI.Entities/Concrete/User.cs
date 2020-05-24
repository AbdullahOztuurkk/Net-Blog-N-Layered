using System.Collections.Generic;
using BlogWebUI.Entities.Abstract;

namespace BlogWebUI.Entities.Concrete
{
    public class User:IDatabaseEntity
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }
        public string Mail { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
