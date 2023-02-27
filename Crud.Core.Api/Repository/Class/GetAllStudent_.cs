using BusinessLayer.Interface;
using DataModel;
using DataModel.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Class
{
    public class GetAllStudent_ : IGetAllStudent
    {
        private DataBaseContext _context;

        public GetAllStudent_(DataBaseContext context)
        {
            _context = context;
        }

        public List<Student> StudentList()
        {
            var data = _context.Students.ToList();   
            return data;
        }
    }
}
