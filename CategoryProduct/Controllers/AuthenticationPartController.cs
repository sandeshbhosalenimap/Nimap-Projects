using CategoryProduct.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CategoryProduct.Controllers
{
    public class AuthenticationPartController : Controller
    {
      
        DataBase db  = new DataBase();
        public ActionResult SignUP()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignUP(LogInCredential b)
        {
            db.LogInCredentials.Add(b); 
            await db.SaveChangesAsync();
            return View();
        }
 
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> LogIn( LogInCredential l)
        {

             var data =  await db.LogInCredentials.AnyAsync( c =>  c.UserName == l.UserName  && c.Password == l.Password );   
            if( data)
            {

                FormsAuthentication.SetAuthCookie(l.UserName, false);
                return RedirectToAction("Index", "Category");
            }    
            return View("LogInFail");
        }


      
    }
}