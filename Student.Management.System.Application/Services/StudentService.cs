using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Student.Management.System.Application.Ports.In;
using Student.Management.System.Application.Ports.Out;

namespace Student.Management.System.Application.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository studentRepository;

        public StudentService( IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public StudentModel AddStudent(StudentModel student)
        {
            return studentRepository.AddStudent(student);
        }

        public List<StudentModel> DeleteStudent(int id)
        {
            return studentRepository.DeleteStudent(id);
        }

        public StudentModel GetStudent(int id)
        {
            return studentRepository.GetStudent(id);
        }

        public List<StudentModel> GetStudents()
        {
            return studentRepository.GetStudents();
        }

        public List<StudentModel> GetStudentsWithSubject(int subjectId)
        {
            return studentRepository.GetStudentsWithSubject(subjectId);
        }

        public StudentModel UpdateStudent(StudentModel student)
        {
            return studentRepository.UpdateStudent(student);
        }
    }
}