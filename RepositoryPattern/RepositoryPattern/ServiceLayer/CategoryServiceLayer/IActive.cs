using CategoryProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer
{
    public interface IActive
    {
        Task ActiveMethod(int CategoryId, int a = 1);
    }


    
}