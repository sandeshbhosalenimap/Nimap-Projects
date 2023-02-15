using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.CategoryRepository
{
    public class NumberOfCPagesRepo  : INumberOfPagesOfCategory
    {
        public double GetNumberOfPagesOfCategory(double b)
        {
             DataBase db =  new DataBase(); 
            double dataCount = db.Categories.Count();
            double NumberOfPagesOfCategory = Math.Ceiling(dataCount / b);
            return NumberOfPagesOfCategory;
        }
    }
}