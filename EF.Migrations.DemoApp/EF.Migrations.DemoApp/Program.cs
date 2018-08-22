using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EF.Migrations.DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //use the real context
            using (var context = new SbEfTestContext())
            {
                var url = $"http://{Guid.NewGuid():N}.com";
                CreateSingleNewBlogPost(url, context);
            
                var matchedByUrl  = context.Blogs.Count(x => x.Url == url);
                Console.WriteLine($"EF SQL Provider found {matchedByUrl} items for Url '{url}'");
            }

            //use the InMemory context
            var options = new DbContextOptionsBuilder<SbEfTestContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

            using (var context = new SbEfTestContext(options))
            {
                var url = $"http://{Guid.NewGuid():N}.com";
                CreateSingleNewBlogPost(url, context);
                context.SaveChanges();
                var matchedByUrl = context.Blogs.Count(x => x.Url == url);
                Console.WriteLine($"EF InMemory Provider found {matchedByUrl} items for Url '{url}'");
            }




        }


        public static void CreateSingleNewBlogPost(string url, SbEfTestContext context)
        {
            var blog = new Blog()
            {
                Url = url,
                CreatedDate = DateTime.Now.ToShortDateString()
            };
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

    }
}
