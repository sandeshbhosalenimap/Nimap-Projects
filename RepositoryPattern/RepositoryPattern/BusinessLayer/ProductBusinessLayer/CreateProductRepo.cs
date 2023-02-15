using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.ProductBusinessLayer
{
    public class CreateProductRepo : ICreateProduct
    {
        public async Task CreateProduct(Product p)
        {
            DataBase db = new DataBase();
            db.Products.Add(p);
            await db.SaveChangesAsync();
        }
    }
}