using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebUI.Entities.Concrete;

namespace BlogWebUI.DataAccess.Concrete.EntityFramework.Mappings
{
    public class EfUserMap:EntityTypeConfiguration<User>
    {
        public EfUserMap()
        {
            ToTable("User", "dbo");
            HasKey(m => m.UserID);

            Property(n => n.Name).HasColumnName("Name");
            Property(m => m.About).HasColumnName("About");
            Property(n => n.Mail).HasColumnName("Mail");
            Property(n => n.Surname).HasColumnName("Surname");
            Property(n => n.UserID).HasColumnName("UserID");

        }
    }
}
