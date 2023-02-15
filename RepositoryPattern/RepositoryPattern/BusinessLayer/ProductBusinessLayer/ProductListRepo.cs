using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.ProductBusinessLayer
{
    public class ProductListRepo : IProductList
    {
        public async Task<List<Product>> ProductList(int CategoryID, double b = 3, int a = 1)
        {
            DataBase db = new DataBase();
            double Count = db.Products.Where(c => c.CategoryId == CategoryID).Count();

            SqlParameter[] value = new SqlParameter[]
            {
                 new SqlParameter("@CategoryId"  , CategoryID),
                 new SqlParameter("@PageSize"  , b),
                 new SqlParameter("@PageIndex"  , a)
            };
            var ProductList = await db.Products.SqlQuery("sp_ProductPaggig @CategoryID  ,@PageIndex ,  @PageSize  ", value).ToListAsync();
            return ProductList;
        }
    }
}