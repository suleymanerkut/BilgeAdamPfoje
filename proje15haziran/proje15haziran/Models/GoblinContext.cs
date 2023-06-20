using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proje15haziran.Models
{
    public class GoblinContext:DbContext
    {
        public GoblinContext():base("GoblinDataBase")
        {
            Database.SetInitializer(new GoblinInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}