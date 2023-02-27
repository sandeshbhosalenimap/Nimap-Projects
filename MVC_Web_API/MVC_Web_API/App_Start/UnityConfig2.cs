using MVC_Web_API.DependancyInjectioon.Bunisess;
using MVC_Web_API.DependancyInjectioon.Service;
using MVC_Web_API.RepositoryPattern.BusinessLayer.ConsumeController;
using MVC_Web_API.RepositoryPattern.ServiceLayer.ConsumeCotroller;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVC_Web_API
{
    public static class UnityConfig2
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IListOfEmployee, ListOFEmploye_>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}