using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Student.Management.System.Application.Ports.In;
using Student.Management.System.Application.Ports.Out;
using Student.Management.System.Domain.Entities.DTOs;

namespace Student.Management.System.Application.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        private IMapper _mapper;

        public StudentService( IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper=mapper;
        }
        public List<GetStudentDto> GetStudents()
        {
            return _mapper.Map<List<GetStudentDto>>(_studentRepository.GetStudents());
        }
        public GetStudentDto GetStudent(int id)
        {
            StudentModel student=_studentRepository.GetStudent(id);
            return _mapper.Map<GetStudentDto>(student);
        }
        public GetStudentDto AddStudent(AddStudentDto addStudentDto)
        {
            StudentModel student = _mapper.Map<StudentModel>(addStudentDto);
            StudentModel addedStudent=_studentRepository.AddStudent(student);
            return _mapper.Map<GetStudentDto>(addedStudent);
        }
        public GetStudentDto DeleteStudent(int id)
        {
            StudentModel student = _studentRepository.DeleteStudent(id);
            return _mapper.Map<GetStudentDto>(student);
        }

        public List<GetStudentDto> GetStudentsWithSubject(int subjectId)
        {
            List<StudentModel> students = _studentRepository.GetStudentsWithSubject(subjectId);
            return _mapper.Map<List<GetStudentDto>>(students);
        }


        public GetStudentDto UpdateStudent(UpdateStudentDto updateStudentDto)
        {
            StudentModel student = _mapper.Map<StudentModel>(updateStudentDto);
            StudentModel updatedStudent=_studentRepository.UpdateStudent(student);
            return _mapper.Map<GetStudentDto>(updatedStudent);
        }

        public List<GetStudentDto> DeleteStudents(int[] ids)
        {
            List<StudentModel> deletedStudents =_studentRepository.DeleteStudents(ids);
            return _mapper.Map<List<GetStudentDto>>(deletedStudents);
        }
    }
}