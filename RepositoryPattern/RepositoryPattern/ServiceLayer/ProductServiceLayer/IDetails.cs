using CategoryProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer
{
    public interface IDetails
    {
        Task<Product> ProductDetails(int ID);
    }
}