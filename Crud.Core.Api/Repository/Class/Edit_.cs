using BusinessLayer.Interface;
using DataModel;
using DataModel.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Class
{
    public class Edit_ : IEdit
    {
        private DataBaseContext _context;   
        public Edit_(DataBaseContext context)
        {
            _context = context;
        }
    
        public void EditStudent(int id ,Student student)
        {
             var data = _context.Students.SingleOrDefault(s => s.Id == id); 
            data.Id = id;
             data.Name = student.Name;
            data.Description= student.Description;
            
            _context.SaveChanges();

        }
       
    }
}
