using Microsoft.EntityFrameworkCore;
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
                FavoriteSubject= new Subject{Name= s.FavoriteSubject.Name, SubjectId= s.FavoriteSubject.SubjectId},
            }).ToList();
        }
        public StudentModel GetStudent(int id)
        {
            StudentModel student= _context.Students.Where(s=>s.Id==id).Select(s=> new StudentModel{
                Id=s.Id,
                FirstName= s.FirstName,
                LastName= s.LastName,
                MiddleName= s.MiddleName,
                DateOfBirth= s.DateOfBirth,
                SubjectId= s.SubjectId,
                FavoriteSubject= new Subject{Name= s.FavoriteSubject.Name, SubjectId= s.FavoriteSubject.SubjectId},
            }).First();
            return student;
        }
        public StudentModel AddStudent(StudentModel student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            StudentModel addedStudent=_context.Students.Where(s=>s.Id==student.Id).Select(s=> new StudentModel{
                Id=s.Id,
                FirstName= s.FirstName,
                LastName= s.LastName,
                MiddleName= s.MiddleName,
                DateOfBirth= s.DateOfBirth,
                SubjectId= s.SubjectId,
                FavoriteSubject= new Subject{Name= s.FavoriteSubject.Name, SubjectId= s.FavoriteSubject.SubjectId},
            }).First();
            return addedStudent;
        }

        public StudentModel DeleteStudent(int id)
        {
            StudentModel student= _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();

            return student;
        }

        public List<StudentModel> DeleteStudents(int[] ids)
        {
            List<StudentModel> deletedStudents=new List<StudentModel>();
            foreach(int id in ids){
                StudentModel deletedStudent=_context.Students.Find(id);
                _context.Students.Remove(deletedStudent);
                deletedStudents.Add(deletedStudent);
            }
            
            _context.SaveChanges();

             return deletedStudents;
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
                FavoriteSubject= new Subject{Name= s.FavoriteSubject.Name, SubjectId= s.FavoriteSubject.SubjectId},
            }).ToList();
        }

        public StudentModel UpdateStudent(StudentModel updateStudent)
        {
            StudentModel student = _context.Students.FirstOrDefault(s => s.Id==updateStudent.Id);

            if (student != null)
            {
                _context.Entry(student).State = EntityState.Detached;
            }
            _context.Entry(updateStudent).State = EntityState.Modified;

            _context.SaveChanges();

            return updateStudent;
        }

    }
}