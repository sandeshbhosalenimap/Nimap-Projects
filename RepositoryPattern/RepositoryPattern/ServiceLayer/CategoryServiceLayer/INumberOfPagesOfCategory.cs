using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer
{
    public interface INumberOfPagesOfCategory
    {
        double GetNumberOfPagesOfCategory(double b);
    }
}