using CategoryProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer
{
    public interface IGetAllCategoryList
    {
        Task<List<Category>> GetAllCategory(double b = 3, int a = 1);
    }
}