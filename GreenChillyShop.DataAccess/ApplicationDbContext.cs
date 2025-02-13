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
        public DbSet<Category>Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Vegetables",DisplayOrder=1},
                new Category { Id=2,Name="Fruits", DisplayOrder =2},
                new Category { Id=3,Name="Sweets", DisplayOrder =3},
                new Category { Id=4,Name="Chocolates", DisplayOrder =4}
                );
            
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1,  Description = "This sections contains vegetables", Name = "Carrot", Price = 2, StockQuantity = 50,CategoryId=1,ImageUrl="" },
                new Product { Id = 2,  Description = "This sections contains Fruits", Name = "Banana", Price = 50, StockQuantity = 150,CategoryId=2,ImageUrl = "" },
                new Product { Id = 3, Description = "This sections contains sweets", Name = "Sona papdi", Price = 112, StockQuantity = 50,CategoryId = 3, ImageUrl="" },
                new Product { Id = 4, Description = "This sections contains Chocolates", Name = "KitKat", Price = 40, StockQuantity = 50, CategoryId = 4, ImageUrl = "" }



                );
        }
    }
}
