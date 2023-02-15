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
    public class EditProductRepo : IEditProduct
    {
        public async Task EditProductDetails(Product p)
        {
            DataBase db = new DataBase();
            db.Entry(p).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}