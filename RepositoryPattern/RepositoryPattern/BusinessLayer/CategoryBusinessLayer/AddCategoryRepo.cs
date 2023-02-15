using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.CategoryRepository
{
    public class AddCategoryRepo :IAddCategory
    {
        public async Task<int> AddCategoryInList(Category c)
        {
            DataBase db = new DataBase();
            db.Categories.Add(c);
            await db.SaveChangesAsync();
            return 9;
        }
    }
}