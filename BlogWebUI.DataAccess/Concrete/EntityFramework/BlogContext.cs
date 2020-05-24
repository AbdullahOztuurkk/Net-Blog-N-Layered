using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.DataAccess.Concrete.EntityFramework.Mappings;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.DataAccess.Concrete.EntityFramework
{
    public class BlogContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BlogContext>(null);
            modelBuilder.Entity<User>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.User);

            modelBuilder.Configurations.Add(new EfArticleMap());
            modelBuilder.Configurations.Add(new EfUserMap());

            //base.OnModelCreating(modelBuilder);
        }
    }
}
