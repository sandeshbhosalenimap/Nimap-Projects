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
    public class GetStudentByID_ : IGetStudentByID
    {
        private DataBaseContext _context;
        public GetStudentByID_(DataBaseContext context)
        {
            _context = context; 
        }
        public Student GetStudentDetails(int id)
        {
   Student  data = _context.Students.SingleOrDefault(s => s.Id == id);    
            return data;
        }
    }
}
