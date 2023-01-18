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
            GetStudentDto getStudentDto = studentService.GetStudent(id);
            if (getStudentDto == null)
            {
                return NotFound();
            }
            return Ok(getStudentDto);
        }

        [HttpPost]
        public ActionResult<GetStudentDto> AddStudent(AddStudentDto student){
            return Ok(studentService.AddStudent(student));
        }

        [HttpPut] 
        public ActionResult<GetStudentDto> UpdateStudent(UpdateStudentDto student){
            GetStudentDto getStudentDto = studentService.UpdateStudent(student);
            if (getStudentDto == null)
            {
                return NotFound();
            }
            return Ok(getStudentDto);
        }

        [HttpDelete("{id}")]
        public ActionResult<GetStudentDto> DeleteStudent(int id){
            GetStudentDto getStudentDto = studentService.DeleteStudent(id);
            if(getStudentDto == null)
            {
                return NotFound();
            }
            return Ok(getStudentDto);
        }

        [HttpDelete]
        public ActionResult<List<GetStudentDto>> DeleteStudents([FromQuery] int[] ids){
            List<GetStudentDto> getStudentDtos = studentService.DeleteStudents(ids);
            if (getStudentDtos.Count == 0) 
            {
                return NotFound();
            }
            return Ok(getStudentDtos);
        }

        [HttpGet("filter/{subjectId}")]
        public ActionResult<List<GetStudentDto>> GetStudentWithSubject(int subjectId){
            return Ok(studentService.GetStudentsWithSubject(subjectId));
        }
    }

}
