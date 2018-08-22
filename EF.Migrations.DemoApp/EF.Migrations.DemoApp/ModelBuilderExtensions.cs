using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EF.Migrations.DemoApp
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                BlogId = 1,
                CreatedDate = DateTime.Now.ToShortDateString(),
                Url = $"http://{Guid.NewGuid().ToString()}.com"
            });
        }
    }
}
