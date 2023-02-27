
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crude.Api.Service.IService
{
    public interface IStudentServices
    {
        void AddNewStudent(Student student);
        void Delete(int id);
        void EditStudent(int id, Student student);
        IEnumerable<Student> StudentList();
        Student GetStudentDetails(int id);
    }
}
