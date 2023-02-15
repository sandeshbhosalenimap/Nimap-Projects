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
    public class ActiveRepository : IActive
    {
        public async Task ActiveMethod(int CategoryId, int a = 1)
        {
            DataBase db = new DataBase();
            SqlParameter[] valu = new SqlParameter[]
           {
                new SqlParameter("@CategoryId",CategoryId),
                new SqlParameter("@Status",a)
           };
            await db.Database.ExecuteSqlCommandAsync("exec sp_ActiveDeactive @CategoryId,@Status ", valu);
        }
    }
}