using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.Models;

namespace DAL
{
    public partial class DALContext : DbContext
    {
        public DALContext()
        {
        }
        public DALContext(DbContextOptions<DALContext> options)
    : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=NIHF;User Id=webuser;Password=Password2019;");
            }
        }

        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Part> Part { get; set; }
    }
}
