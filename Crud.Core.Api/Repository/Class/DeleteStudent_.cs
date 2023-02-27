using BusinessLayer.Interface;
using DataModel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Class
{
    public class DeleteStudent_ : IDelete
    {
        private DataBaseContext _context;
        public DeleteStudent_(DataBaseContext context)
        {
            _context = context; 
        }
        public void Delete(int id)
        {
            var data = _context.Students.SingleOrDefault(x => x.Id == id);      
             _context.Students.Remove(data);
            _context.SaveChanges(); 
        }
    }
}
