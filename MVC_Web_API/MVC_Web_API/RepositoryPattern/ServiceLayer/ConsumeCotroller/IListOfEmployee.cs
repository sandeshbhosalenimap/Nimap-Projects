
using MVC_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace MVC_Web_API.RepositoryPattern.ServiceLayer.ConsumeCotroller
{
    public interface IListOfEmployee
    {
        List<emp> ListOFEmploye();
    }
}