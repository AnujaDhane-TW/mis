global using Student.Management.System.Domain.Entities;
using Student.Management.System.Domain.Entities.DTOs;

namespace Student.Management.System.Application.Ports.In
{
    public interface IStudentService
    {
        List<GetStudentDto> GetStudents();
        GetStudentDto GetStudent(int id);
        GetStudentDto AddStudent(AddStudentDto student);
        GetStudentDto DeleteStudent(int id);
        List<GetStudentDto> GetStudentsWithSubject(int subjectId);
        StudentModel UpdateStudent(StudentModel student);
    }
}