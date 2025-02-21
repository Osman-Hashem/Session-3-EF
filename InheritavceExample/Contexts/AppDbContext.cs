using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritavceExample.Models;
using Microsoft.EntityFrameworkCore;

namespace InheritavceExample.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPC
            //modelBuilder.Entity<Employees>().ToTable("Employees");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = InheritavceExample; Trusted_Connection = True; TrustServerCertificate = True");
        }

        //public DbSet<Employees> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }

    }

}
