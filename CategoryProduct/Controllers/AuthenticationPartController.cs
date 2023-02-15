
using CategoryProduct.JWT_Token;
using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.AuthenticationServiceLayer;
using IdentityServer4.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows.Input;
using System.Xml.Linq;
using Twilio.Http;
using Twilio.TwiML.Voice;
namespace CategoryProduct.Controllers
{
    public class AuthenticationPartController : Controller
    {
        private ILogIn _logIn;
        private ISignUP _signUP;

        public AuthenticationPartController(ILogIn logIn, ISignUP signUP)
        {
            _logIn = logIn;
            _signUP = signUP;
        }

        public ActionResult SignUP()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignUP(LogInCredential b)
        {
            if (ModelState.IsValid)
            {
                await _signUP.SignUP(b);
            }
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> LogIn(LogInCredential l)
        {
            if (ModelState.IsValid)
            {
                var data = await _logIn.LogIn(l);
                var token = JWTHelper.CreateJWTToken(data);
                if (token != null)
                {

                    Response.Cookies.Set(new HttpCookie("token", token));
                    return RedirectToAction("Index", "Category");
                }
            }
            return View("LogInFail");
        }
        public ActionResult PageError401()
        {
            return View();
        }

    }
}