using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EF.Migrations.DemoApp
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<SbEfTestContext>
    {
        public SbEfTestContext CreateDbContext(string[] args)
        {
            var connString =
                "data source = localhost;initial catalog = EF_TEST; persist security info = True;Integrated Security = SSPI;";
            var optionsBuilder = new DbContextOptionsBuilder<SbEfTestContext>();
            optionsBuilder.UseSqlServer(connString);
            return new SbEfTestContext(optionsBuilder.Options);
        }
    }
}
