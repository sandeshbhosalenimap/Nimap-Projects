using CategoryProduct.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Data.SqlClient;
using System.Web.Security;
using System.Threading.Tasks;

namespace CategoryProduct.Controllers
{
    
    public class CategoryController : Controller
    {
        DataBase db = new DataBase();
         [Authorize]
        public async Task<ActionResult> Index(double b = 3, int a = 1)
        {
            double dataCount = db.Categories.Count();


            SqlParameter[] valu = new SqlParameter[]
           {
                new SqlParameter("@pagiSize",b),
                new SqlParameter("@PageIndex",a)
           };

            var data = await db.Categories.SqlQuery("Sp_CategoryPagging @PageIndex , @pagiSize", valu).ToListAsync();
            ViewBag.TotalPages = Math.Ceiling(dataCount / b);

            return View(data);
        }

       
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory(Category c)
        {
              db.Categories.Add(c);
           await db.SaveChangesAsync();
            return View();
        }


         public async Task<ActionResult> Active(int CategoryId , int a=1)
        {
            SqlParameter[] valu = new SqlParameter[]
           {
                new SqlParameter("@CategoryId",CategoryId),
                new SqlParameter("@Status",a)
           };
           await db.Database.ExecuteSqlCommandAsync("exec sp_ActiveDeactive @CategoryId,@Status ", valu);
            return RedirectToAction ("Index");  
      
        }


        public async Task<ActionResult> Deactive(int CategoryId, int a = 0)
        {
            SqlParameter[] valu = new SqlParameter[]
           {
                new SqlParameter("@CategoryId",CategoryId),
                new SqlParameter("@Status",a)
           };
           await db.Database.ExecuteSqlCommandAsync("exec sp_ActiveDeactive @CategoryId,@Status ", valu);
            return RedirectToAction("Index");

        }

        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn", "AuthenticationPart");
        }
    }
}