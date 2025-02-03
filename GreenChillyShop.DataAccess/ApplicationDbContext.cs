using GreenChillyShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        //Applicationd db
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Product>Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Category = "Vegetables", Description = "This sections contains vegetables", Name = "Carrot", Price = 2, StockQuantity = 50 },
                new Product { Id = 2, Category = "Fruits", Description = "This sections contains Fruits", Name = "Banana", Price = 50, StockQuantity = 150 },
                new Product { Id = 3, Category = "Sweets", Description = "This sections contains sweets", Name = "Sona papdi", Price = 112, StockQuantity = 50 }


                );
        }
    }
}
