using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.CategoryRepository
{
    public class CategoryListRepo : IGetAllCategoryList
    {

        public async Task<List<Category>> GetAllCategory(double b = 3, int a = 1)
        {
            DataBase db = new DataBase();       
            SqlParameter[] valu = new SqlParameter[]
            {
                new SqlParameter("@pagiSize",b),
                new SqlParameter("@PageIndex",a)
            };
            var data = await db.Categories.SqlQuery("Sp_CategoryPagging @PageIndex , @pagiSize", valu).ToListAsync();
            return data;
        }
    }
}