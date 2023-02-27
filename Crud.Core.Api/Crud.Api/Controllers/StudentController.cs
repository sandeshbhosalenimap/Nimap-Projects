
using Crude.Api.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Api.Controllers
{

    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentServices _studentService;
        public StudentController (IStudentServices student)
        {
            _studentService = student; 
        }




         [HttpGet]
        [Route("Student/StudentList")]
        public IActionResult StudentList()
        {
            var data = _studentService.StudentList();
            return Ok(data);
        }

        [HttpGet]
        [Route("Student/GetStudentByID/{id}")]
        public IActionResult GetStudentByID([FromRoute] int id)
        {
            var student = _studentService.GetStudentDetails(id);
            return Ok(student);
        }

        [HttpPut]
        [Route("Student/EditStudent/{id}")]
        public IActionResult EditStudent([FromRoute] int id , [FromBody] Student student)
        {
            _studentService.EditStudent(id, student); 
            return Ok();    
        }
        [HttpDelete]
        [Route("Student/DeleteStudent{id}")]
        public IActionResult DeleteStudent([FromRoute] int id)
        {
            _studentService.Delete(id);
            return Ok();
        }
        [HttpPost]
        [Route("Student/CreateStudent")]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            _studentService.AddNewStudent(student);
            return Ok();
        }

    }
}
