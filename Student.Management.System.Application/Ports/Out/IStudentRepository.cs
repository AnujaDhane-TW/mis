namespace Student.Management.System.Application.Ports.Out
{
    public interface IStudentRepository
    {
        List<StudentModel> GetStudents();
    }
}