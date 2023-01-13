using Student.Management.System.Application.Ports.Out;
using Student.Management.System.Domain.Entities;
using Student.Management.System.Infrastructure.Data;

namespace Student.Management.System.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
     
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
            
        }
        public List<StudentModel> GetStudents()
        {
            return _context.Students.Select(s=> new StudentModel{
                Id=s.Id,
                FirstName= s.FirstName,
                LastName= s.LastName,
                MiddleName= s.MiddleName,
                DateOfBirth= s.DateOfBirth,
                SubjectId= s.SubjectId,
                FavouriteSubject= new Subject{Name= s.FavouriteSubject.Name, SubjectId= s.FavouriteSubject.SubjectId},
            }).ToList();
        }
        public StudentModel GetStudent(int id)
        {
            StudentModel student= _context.Students.Find(id);
            return student;
        }
        public StudentModel AddStudent(StudentModel student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public List<StudentModel> DeleteStudent(int id)
        {
            StudentModel student= _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();

            return GetStudents();
        }

        public List<StudentModel> GetStudentsWithSubject(int subjectId)
        {
            
            return _context.Students.Where(s=>s.SubjectId==subjectId).Select(s=> new StudentModel{
                Id=s.Id,
                FirstName= s.FirstName,
                LastName= s.LastName,
                MiddleName= s.MiddleName,
                DateOfBirth= s.DateOfBirth,
                SubjectId= s.SubjectId,
                FavouriteSubject= new Subject{Name= s.FavouriteSubject.Name, SubjectId= s.FavouriteSubject.SubjectId},
            }).ToList();
        }

        public StudentModel UpdateStudent(StudentModel student)
        {
            return student;
        }

        
    }
}