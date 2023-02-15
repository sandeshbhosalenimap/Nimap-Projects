using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.AuthenticationServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.AuthenticationBusinessLayer
{
    public class SignUPRepo : ISignUP
    {
        public async Task SignUP(LogInCredential b)
        {
            DataBase  db = new DataBase();  
            db.LogInCredentials.Add(b);
            await db.SaveChangesAsync();
        }
    }
}