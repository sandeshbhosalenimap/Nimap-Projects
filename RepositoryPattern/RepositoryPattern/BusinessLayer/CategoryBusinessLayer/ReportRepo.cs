using CategoryProduct.Models;
using CategoryProduct.RepositoryPattern.ServiceLayer.CategoryServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.BusinessLayer.CategoryRepository
{
    public class ReportRepo : IReport
    {
        public async Task<List<Report>> ReportMethd()
        {
            DataBase db = new DataBase ();
            List<Report> report = new List<Report>();
            var data = await db.Database.SqlQuery<Report>("sp_Report").ToListAsync();
            foreach (var item in data)
            {
                report.Add(item);
            }
            return report;
        }
    }
}