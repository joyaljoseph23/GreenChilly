﻿using GreenChillyShop.DataAccess.Repository.IRepository;
using GreenChillyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
       private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

       

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
