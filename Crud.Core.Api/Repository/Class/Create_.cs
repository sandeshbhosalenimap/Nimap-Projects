using BusinessLayer.Interface;
using DataModel;
using DataModel.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer.Class
{
    public class Create_ : ICreate
    {
        private DataBaseContext _context;
     
        public Create_(DataBaseContext context)
        {
            _context = context;
        }

        public Create_()
        {
        }

        public dynamic data;
        public void AddNewStudent(Student student)
        {
            dynamic data = student;
            _context.Students.Add(student);
            _context.SaveChanges();
        
        }
        
      

    }
}
