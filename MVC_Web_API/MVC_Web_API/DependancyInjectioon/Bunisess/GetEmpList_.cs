using MVC_Web_API.DependancyInjectioon.Service;
using MVC_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVC_Web_API.DependancyInjectioon.Bunisess
{
    public class GetEmpList_ : IGetList
    {
        public List<emp> GetEmpList()
        {
            cdac2022Entities db = new cdac2022Entities();
            List<emp> sm = db.emps.ToList();
            return sm;      
        }
    }
}