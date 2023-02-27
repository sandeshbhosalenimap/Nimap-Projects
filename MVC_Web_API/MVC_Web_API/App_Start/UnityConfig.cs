using MVC_Web_API.DependancyInjectioon.Bunisess;
using MVC_Web_API.DependancyInjectioon.Service;
using MVC_Web_API.RepositoryPattern.BusinessLayer.ConsumeController;
using MVC_Web_API.RepositoryPattern.ServiceLayer.ConsumeCotroller;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace MVC_Web_API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IGetList, GetEmpList_>();


            container.RegisterType<IListOfEmployee, ListOFEmploye_>();

          
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}