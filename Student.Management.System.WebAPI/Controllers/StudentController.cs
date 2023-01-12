using Microsoft.AspNetCore.Mvc;
using Student.Management.System.Application.Ports.In;

namespace Student.Management.System.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentService studentService;
      
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
            
        }
        [HttpGet]
        public ActionResult<List<StudentModel>> GetStudents(){
            
            return Ok(studentService.GetStudents());
        }

    }

}
