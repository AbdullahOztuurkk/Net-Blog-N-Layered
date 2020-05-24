using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.DataAccess.Concrete.EntityFramework.Mappings
{
    public class EfArticleMap : EntityTypeConfiguration<Article>
    {
        public EfArticleMap()
        {
            ToTable("Article", "dbo");
            HasKey(m => m.ArticleID);

            Property(n => n.Keywords).HasColumnName("Keywords");
            Property(n => n.ArticleID).HasColumnName("ArticleID");
            Property(m => m.UserID).HasColumnName("UserID");
            Property(n => n.Content).HasColumnName("Content");
            Property(n => n.CreateDate).HasColumnName("CreateDate");
            Property(n => n.Title).HasColumnName("Title");

            /*HasOptional(tablodaki => tablodaki.User).
                WithMany(tablodaki => tablodaki.Articles).
                HasForeignKey(d => d.UserID);
            */
            HasRequired(tablo => tablo.User).
                WithMany(tablo => tablo.Articles).
                HasForeignKey(tablo => tablo.UserID);
        }
    }
}
