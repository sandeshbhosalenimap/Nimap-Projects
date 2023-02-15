using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer
{
    public interface INumberOfPage
    {
        double NumberOfPagesOfproductList(int CategoryID, double b);
    }
}