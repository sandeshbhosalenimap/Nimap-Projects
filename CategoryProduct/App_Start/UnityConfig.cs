
using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.BusinessLayer.AuthenticationBusinessLayer;
using CategoryProduct.RepositoryPattern.BusinessLayer.CategoryRepository;
using CategoryProduct.RepositoryPattern.BusinessLayer.ProductBusinessLayer;
using CategoryProduct.RepositoryPattern.ServiceLayer.AuthenticationServiceLayer;
using CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer;
using CategoryProduct.RepositoryPattern.ServiceLayer.ProductServiceLayer;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CategoryProduct
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
           
             //Category
            
            container.RegisterType<IActive, ActiveRepository>();
            container.RegisterType<IAddCategory, AddCategoryRepo>();
            container.RegisterType<IDeactive, DeactiveRepository>();
            container.RegisterType<IGetAllCategoryList, CategoryListRepo>();
            container.RegisterType<INumberOfPagesOfCategory, NumberOfCPagesRepo>();
            container.RegisterType<IReport, ReportRepo>();

            //Product
            container.RegisterType<ICreateProduct, CreateProductRepo>();
            container.RegisterType<IDelete, DeleteRepo>();
            container.RegisterType<IDetails, DetailsRepo>();
            container.RegisterType<IEditProduct, EditProductRepo>();
            container.RegisterType<INumberOfPage, NumberOfPageRepo>();
            container.RegisterType<IProductList, ProductListRepo>();

            //Authentication 
            container.RegisterType<ISignUP, SignUPRepo>();
            container.RegisterType<ILogIn, LogInRepo>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}