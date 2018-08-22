using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EF.Migrations.DemoApp
{
    public class SbEfTestContext : DbContext
    {
        public SbEfTestContext()
        {
        }

        public SbEfTestContext(DbContextOptions<SbEfTestContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = "data source = localhost;initial catalog = EF_TEST; persist security info = True;Integrated Security = SSPI;";
                optionsBuilder.UseSqlServer(connString);
            }
        }

    }
}
