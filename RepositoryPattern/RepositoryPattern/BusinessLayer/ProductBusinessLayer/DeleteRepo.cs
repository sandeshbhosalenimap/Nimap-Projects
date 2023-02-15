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
    public class DeleteRepo : IDelete
    {
        public async Task Delete(int ID)
        {
            DataBase db = new DataBase();
            Product data = await db.Products.Where(m => m.ProductId == ID).FirstOrDefaultAsync();
            db.Entry(data).State = EntityState.Deleted;
            await db.SaveChangesAsync();

        }
    }
}