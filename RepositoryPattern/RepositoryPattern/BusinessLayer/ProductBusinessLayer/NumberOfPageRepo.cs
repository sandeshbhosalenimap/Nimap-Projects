using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.ProductBusinessLayer
{
    public class NumberOfPageRepo : INumberOfPage
    {
        public double NumberOfPagesOfproductList(int CategoryID, double b)
        {
            DataBase db = new DataBase();
            var NumberOfProduct = db.Products.Where(c => c.CategoryId == CategoryID).Count();
            double NumberOfpages = Math.Ceiling(NumberOfProduct / b);
            return NumberOfpages;
        }
    }
}