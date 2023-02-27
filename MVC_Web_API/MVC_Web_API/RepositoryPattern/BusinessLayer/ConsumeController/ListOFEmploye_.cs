
using MVC_Web_API.Models;
using MVC_Web_API.RepositoryPattern.ServiceLayer.ConsumeCotroller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;


namespace MVC_Web_API.RepositoryPattern.BusinessLayer.ConsumeController
{
    public class ListOFEmploye_ : IListOfEmployee
    {
        HttpClient hc = new HttpClient();
        public List<emp> ListOFEmploye()
        {
            hc.BaseAddress = new Uri("https://localhost:44357/api/WebApi/GetEmpList");
            List<emp> List = new List<emp>();

            var consume = hc.GetAsync("GetEmpList");
            consume.Wait();
            var test = consume.Result;
            if (test.IsSuccessStatusCode)
            {
                var dispalyi = test.Content.ReadAsAsync<List<emp>>();
                List = dispalyi.Result;
            }
            return List;
        }
    }
}