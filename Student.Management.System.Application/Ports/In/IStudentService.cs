global using Student.Management.System.Domain.Entities;


namespace Student.Management.System.Application.Ports.In
{
    public interface IStudentService
    {
        StudentModel AddStudent(StudentModel student);
        List<StudentModel> DeleteStudent(int id);
        StudentModel GetStudent(int id);
        List<StudentModel> GetStudents();
        List<StudentModel> GetStudentsWithSubject(int subjectId);
        StudentModel UpdateStudent(StudentModel student);
    }
}