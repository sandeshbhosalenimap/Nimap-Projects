using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer
{
    public interface IDeactive
    {
        Task DeactiveMethod(int CategoryId, int a = 0);
    }
}
