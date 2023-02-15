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

using System.Security.RightsManagement;

using CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer;

namespace CategoryProduct.Controllers
{
    public class CategoryController : Controller
    {
        private IActive _active;
        private IAddCategory _addCategory;
        private IDeactive _deactive;
        private IGetAllCategoryList _getAllCategoryList;
        private INumberOfPagesOfCategory _numberOfPagesOfCategory;
        private IReport _report;

        public CategoryController(IActive active, IAddCategory addCategory, IDeactive deactive, IGetAllCategoryList getAllCategoryList, INumberOfPagesOfCategory numberOfPagesOfCategory, IReport report)
        {
            _active = active;
            _addCategory = addCategory;
            _deactive = deactive;
            _getAllCategoryList = getAllCategoryList;
            _numberOfPagesOfCategory = numberOfPagesOfCategory;
            _report = report;
        }

        [AllowAnonymous]
        public async Task<ActionResult> Index(double b = 3, int a = 1)
        {
            var CategoryList = await _getAllCategoryList.GetAllCategory(b, a);
            ViewBag.TotalPages = _numberOfPagesOfCategory.GetNumberOfPagesOfCategory(b);

            return View(CategoryList);
        }

        
        [Authorize(Roles = "admin")]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> AddCategory(Category c)
        {
            if (ModelState.IsValid)
            {
                await _addCategory.AddCategoryInList(c);
            }
            else { return View("Index"); }

            return View();
        }


        [Authorize(Roles = "hr")]
        public async Task<ActionResult> Active(int CategoryId, int a = 1)
        {
            await _active.ActiveMethod(CategoryId, a);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Deactive(int CategoryId, int a = 0)
        {
            await _deactive.DeactiveMethod(CategoryId, a);
            return RedirectToAction("Index");

        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn", "AuthenticationPart");
        }

        [Authorize(Roles = "admin")]
        public async Task<ActionResult> ReportMethd()
        {
            List<Report> report = await _report.ReportMethd();
            return View(report);
        }

    }
}