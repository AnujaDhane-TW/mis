using Microsoft.AspNetCore.Mvc;
using Student.Management.System.Application.Ports.In;
using Student.Management.System.Domain.Entities.DTOs;

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
        public ActionResult<List<GetStudentDto>> GetStudents(){
            
            return Ok(studentService.GetStudents());
        }

        [HttpGet("{id}")]
        public ActionResult<GetStudentDto> GetStudent(int id){
            return Ok(studentService.GetStudent(id));
        }

        [HttpPost]
        public ActionResult<GetStudentDto> AddStudent(AddStudentDto student){
            return Ok(studentService.AddStudent(student));
        }

        [HttpPut] 
        public ActionResult<GetStudentDto> UpdateStudent(UpdateStudentDto student){
            return Ok(studentService.UpdateStudent(student));
        }

        [HttpDelete("{id}")]
        public ActionResult<StudentModel> DeleteStudent(int id){
            return Ok(studentService.DeleteStudent(id));
        }

        [HttpDelete]
        public ActionResult<List<GetStudentDto>> DeleteStudents([FromQuery] int[] ids){
            return Ok(studentService.DeleteStudents(ids));
        }

        [HttpGet("filter/{subjectId}")]
        public ActionResult<List<GetStudentDto>> GetStudentWithSubject(int subjectId){
            return Ok(studentService.GetStudentsWithSubject(subjectId));
        }
    }

}
