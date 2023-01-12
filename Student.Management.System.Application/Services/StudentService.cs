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

        public List<StudentModel> GetStudents()
        {
            return studentRepository.GetStudents();
        }
    }
}