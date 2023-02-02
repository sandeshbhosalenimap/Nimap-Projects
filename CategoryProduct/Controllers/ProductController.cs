using CategoryProduct.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CategoryProduct.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        DataBase db = new DataBase();

       

        public async Task<ActionResult> ProductList(int CategoryID , double b=3 , int a=1 )
        {
            
            Session["CategoryIDForList"] = CategoryID;
             double Count = db.Products.Where(c => c.CategoryId == CategoryID).Count();

            SqlParameter[] value = new SqlParameter[]
            {
                 new SqlParameter("@CategoryId"  , CategoryID),
                 new SqlParameter("@PageSize"  , b),
                 new SqlParameter("@PageIndex"  , a)
            };

            ViewBag.TotalPagesOfProduct = Math.Ceiling(Count / b);
            var data =  await db.Products.SqlQuery("sp_ProductPaggig @CategoryID  ,@PageIndex ,  @PageSize  ", value).ToListAsync();    
          
            return View(data);
        }

        public ActionResult Create(int CategoryID)
        {
             Session["CategoryID"] = CategoryID;
             return View();
        }


        [HttpPost]
        public async Task<ActionResult> Create(Product p)
        {
            db.Products.Add(p);
            await db.SaveChangesAsync();

            return View();
        }


        
        public async Task<ActionResult> Edit(int ID)
        { 
            Product data  = await db.Products.Where( c => c.ProductId== ID).FirstOrDefaultAsync();
            Session["EditID"] = data.CategoryId;
           
            return View(data);
        }

        [ HttpPost]  
        public async Task<ActionResult> Edit(Product p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChangesAsync();   
            return View();
        }

        public async Task<ActionResult> Details(int ID)
        {
            DataBase db = new DataBase();
            var products = await db.Products.SingleAsync(c => c.ProductId == ID);
            return View(products);
        }

  
        public async Task<ActionResult> Delete(int ID)
        {
            DataBase db = new DataBase();   
            Product data = await db.Products.Where(m => m.ProductId == ID).FirstOrDefaultAsync();
            Session["DeleteID"] = data.CategoryId;

              db.Entry(data).State = EntityState.Deleted;
              await db.SaveChangesAsync();

              return View();
    
        }
    }
}