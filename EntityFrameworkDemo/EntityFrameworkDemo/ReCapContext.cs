using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class RecapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;database=recap;trusted_connection=true");
        }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Personel> Personels { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>().ToTable("Employees");
            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeId");
            modelBuilder.Entity<Personel>().Property(p => p.FirstName).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.LastName).HasColumnName("LastName");
        }
    }
    
}
