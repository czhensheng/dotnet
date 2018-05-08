using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    public class BlogContext : DbContext
    {

        public DbSet<Blog> Blogs { get; set; }

        //public DbSet<Blog> Posts { get; set; }
        public BlogContext() : base("name=base")
        {

        }


    }
}
