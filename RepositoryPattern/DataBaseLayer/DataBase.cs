using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CategoryProduct.Models
{
    public class DataBase :  DbContext
    {
        public DbSet<Category> Categories { get; set; } 

        public DbSet<Product> Products { get; set; }
        public DbSet<LogInCredential> LogInCredentials { get; set; }

        public System.Data.Entity.DbSet<CategoryProduct.Models.Report> Reports { get; set; }
    }
}