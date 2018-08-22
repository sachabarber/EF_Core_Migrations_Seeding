using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EF.Migrations.ScaffoldedBack.Models
{
    public partial class EF_TESTContext : DbContext
    {
        public EF_TESTContext()
        {
        }

        public EF_TESTContext(DbContextOptions<EF_TESTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source = localhost;initial catalog = EF_TEST; persist security info = True;Integrated Security = SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Url).IsRequired();
            });
        }
    }
}
