using Student.Management.System.Application.Ports.Out;
using Student.Management.System.Domain.Entities;

namespace Student.Management.System.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<StudentModel> students= new List<StudentModel>{      
            new StudentModel(),
            new StudentModel()
        };

        public StudentModel AddStudent(StudentModel student)
        {
            return student;
        }

        public List<StudentModel> DeleteStudent(int id)
        {
            return students;
        }

        public StudentModel GetStudent(int id)
        {
            return new StudentModel();
        }

        public List<StudentModel> GetStudents()
        {
            return students;
        }

        public List<StudentModel> GetStudentsWithSubject(int subjectId)
        {
            return students;
        }

        public StudentModel UpdateStudent(StudentModel student)
        {
            return student;
        }

        
    }
}