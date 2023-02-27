
using MVC_Web_API.DependancyInjectioon.Service;
using MVC_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MVC_Web_API.Controllers
{
    public class WebApiController : ApiController
    {
        cdac2022Entities db = new cdac2022Entities();

        private IGetList _getList;

        public WebApiController( IGetList getList)
        {

            _getList = getList;
        }   

        [HttpGet]
        public IHttpActionResult GetEmpList()
        {
            List<emp> data = _getList.GetEmpList(); 
            return Ok(data);
        }

        public IHttpActionResult AddData(dept d)
        {
            db.depts.Add(d);
            db.SaveChanges();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var data = db.emps.Where(c => c.empcode == id.ToString()).SingleOrDefault();
            db.emps.Remove(data);

            db.SaveChanges();

            return Ok();
        }
    }
}
