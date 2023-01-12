using Microsoft.AspNetCore.Mvc;
using Student.Management.System.Application.Ports.In;

namespace Student.Management.System.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet("{id}")]
        public ActionResult<StudentModel> GetStudent(int id){
            return Ok(studentService.GetStudent(id));
        }

        [HttpPost]
        public ActionResult<StudentModel> AddStudent(StudentModel student){
            return Ok(studentService.AddStudent(student));
        }

        [HttpPut] //to be refactored to patch
        public ActionResult<StudentModel> UpdateStudent(StudentModel student){
            return Ok(studentService.UpdateStudent(student));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<StudentModel>> DeleteStudent(int id){
            return Ok(studentService.DeleteStudent(id));
        }

        [HttpGet("filter/{subjectId}")]
        public ActionResult<List<StudentModel>> GetStudentWithSubject(int subjectId){
            return Ok(studentService.GetStudentsWithSubject(subjectId));
        }
    }

}
