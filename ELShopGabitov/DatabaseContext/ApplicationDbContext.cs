using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELShopGabitov.Entities;
using Microsoft.EntityFrameworkCore;

namespace ELShopGabitov.DatabaseContext
{
    class ApplicationDbContext : DbContext
    {

        DbSet<ProductEntity> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>(productsConfigration =>
            {
                productsConfigration.HasKey(p => p.Id);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=123456789;database=ELShopGabitov;",
                new MySqlServerVersion(new Version(8, 0, 40)));
        }
    }
}
