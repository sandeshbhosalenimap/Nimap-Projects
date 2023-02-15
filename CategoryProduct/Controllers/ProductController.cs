
using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer;

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

    public class ProductController : Controller
    {

        private ICreateProduct _createProduct;
        private IDelete _delete;
        private IDetails _details;
        private IEditProduct _editProduct;
        private INumberOfPage _numberOfPage;
        private IProductList _productList;

        public ProductController(ICreateProduct createProduct, IDelete delete, IDetails details, IEditProduct editProduct, INumberOfPage numberOfPage, IProductList productList)
        {
            _createProduct = createProduct;
            _delete = delete;
            _details = details;
            _editProduct = editProduct;
            _numberOfPage = numberOfPage;
            _productList = productList;

        }

        public async Task<ActionResult> ProductList(int CategoryID, double b = 3, int a = 1)
        {
            Session["CategoryIDForList"] = CategoryID;
            var ProductList = await _productList.ProductList(CategoryID, b, a);
            ViewBag.TotalPagesOfProduct = _numberOfPage.NumberOfPagesOfproductList(CategoryID, b);
            return View(ProductList); ;
        }

        public ActionResult Create(int CategoryID)
        {
            Session["CategoryID"] = CategoryID;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Product p)
        {
            if (ModelState.IsValid)
            {
                await _createProduct.CreateProduct(p);
            }
            return View();

        }
        public async Task<ActionResult> Edit(int ID)
        {
            Product DetailsOfProduct = await _details.ProductDetails(ID);
            Session["EditID"] = DetailsOfProduct.CategoryId;
            return View(DetailsOfProduct);
        }

        [HttpPut]
        public async Task<ActionResult> Edit(Product p)
        {
            if (ModelState.IsValid)
            {
                await _editProduct.EditProductDetails(p);
            }
            return View();
        }

        public async Task<ActionResult> Details(int ID)
        {
            Product DetailsOfProduct = await _details.ProductDetails(ID);
            return View(DetailsOfProduct);
        }

        public async Task<ActionResult> Delete(int ID)
        {
            Product DetailsOfProduct = await _details.ProductDetails(ID);
            Session["DeleteID"] = DetailsOfProduct.CategoryId;
            await _delete.Delete(ID);
            return View();

        }
    }
}