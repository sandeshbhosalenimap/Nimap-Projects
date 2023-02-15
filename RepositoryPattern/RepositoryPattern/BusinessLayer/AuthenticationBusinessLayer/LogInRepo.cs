using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.AuthenticationServiceLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.AuthenticationBusinessLayer
{
    public class LogInRepo : ILogIn
    {
        public async Task<LogInCredential> LogIn(LogInCredential l)
        {
            DataBase db = new DataBase ();
            LogInCredential data = await db.LogInCredentials.FirstOrDefaultAsync(c => c.UserName == l.UserName && c.Password == l.Password && c.Role == l.Role);

            return data;
        }
    }
}