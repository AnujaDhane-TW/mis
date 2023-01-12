namespace Student.Management.System.Application.Ports.Out
{
    public interface IStudentRepository
    {
        List<StudentModel> GetStudents();

        StudentModel AddStudent(StudentModel student);
        StudentModel UpdateStudent(StudentModel student);
        List<StudentModel> DeleteStudent(int id);
        StudentModel GetStudent(int id);
        List<StudentModel> GetStudentsWithSubject(int subjectId);
    }
}