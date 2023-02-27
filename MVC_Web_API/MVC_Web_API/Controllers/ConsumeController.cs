
using MVC_Web_API.Models;
using MVC_Web_API.RepositoryPattern.ServiceLayer.ConsumeCotroller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace MVC_Web_API.Controllers
{
    public class ConsumeController : Controller
    {
        HttpClient hc = new HttpClient();
        // GET: Consume
        private IListOfEmployee _listOfEmployee;
        public ConsumeController(IListOfEmployee listOfEmployee)
        {
            _listOfEmployee = listOfEmployee;   
        }

        public  ActionResult ListOFEmploye()
        {
            /*hc.BaseAddress = new Uri("https://localhost:44357/api/WebApi/GetEmpList");
            List<emp> List = new List<emp>();

            var consume = hc.GetAsync("GetEmpList");
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                var dispalyi = test.Content.ReadAsAsync<List<emp>>();
                List = dispalyi.Result;
            }*/
            List<emp> List = _listOfEmployee.ListOFEmploye();
            return View(List);
        }
        public ActionResult SendDat()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SendData(dept d)
        {
            hc.BaseAddress = new Uri("https://localhost:44357/api/WebApi/AddData");
            var consume = hc.PostAsJsonAsync("AddData", d);
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }

        }
        public ActionResult DeleteData(int id)
        {
            hc.BaseAddress = new Uri("https://localhost:44357/api/WebApi/Delete");
            var consume = hc.DeleteAsync("Delete?id=" + id.ToString());
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }

        }
    }

}