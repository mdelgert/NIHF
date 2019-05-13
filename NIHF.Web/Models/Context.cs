using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NIHF.Web.Models
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }
        public Context(DbContextOptions<Context> options)
    : base(options)
        {
        }

        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Part> Part { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=NIHF;User Id=webuser;Password=Password2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasKey(e => e.PartID);

                entity.Property(e => e.Number)
               .IsRequired()
               .HasMaxLength(5)
               .IsUnicode(false);

                entity.Property(e => e.Name)
               .IsRequired()
               .HasMaxLength(50)
               .IsUnicode(false);

                entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId);

               entity.Property(e => e.ManufacturerName)
              .IsRequired()
              .HasMaxLength(50)
              .IsUnicode(false);

            });


        }

        }

}
