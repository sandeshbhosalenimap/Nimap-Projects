
using MVC_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVC_Web_API.DependancyInjectioon.Service
{
    public interface IGetList
    {
        List<emp> GetEmpList();
    }
}