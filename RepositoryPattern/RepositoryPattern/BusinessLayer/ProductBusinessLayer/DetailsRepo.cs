using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.ProductBusinessLayer
{
    public class DetailsRepo : IDetails
    {
        public async Task<Product> ProductDetails(int ID)
        {
            DataBase db = new DataBase();
            Product ProductDetails = await db.Products.Where(c => c.ProductId == ID).FirstOrDefaultAsync();
            return ProductDetails;
        }
    }
}