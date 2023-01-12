global using Student.Management.System.Domain.Entities;


namespace Student.Management.System.Application.Ports.In
{
    public interface IStudentService
    {
        List<StudentModel> GetStudents();
    }
}