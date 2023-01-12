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
        public List<StudentModel> GetStudents()
        {
            return students;
        }
    }
}