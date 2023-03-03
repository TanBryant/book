using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBSchema.Responsitory
{
    public class AppDB : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Suppllers> Suppllers { get; set; }
        public string ConnectionString { get; }



        public AppDB()
        {
            var appFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbFolder = Path.Combine(appFolder, "e-commerce.db");
            ConnectionString = dbFolder;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={ConnectionString} ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>(t =>
                                   t.HasKey(ot => new { ot.OrderID, ot.ProductID }));
        }

    }
}
