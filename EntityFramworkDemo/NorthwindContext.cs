using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindDemo
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Personel> Personels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent mapping
            //modelBuilder.HasDefaultSchema("Admin");
            modelBuilder.Entity<Personel>().ToTable("Employees");

            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeId");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");

        }

    }
    
    
}
