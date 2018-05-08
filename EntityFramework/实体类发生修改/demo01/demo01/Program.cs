using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
                db.Blogs.Add(new Blog
                {
                    Name = "czs"
                });
                db.SaveChanges();
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(blog.Name);
                }
            }
        }
    }
}
