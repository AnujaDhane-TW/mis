using AutoMapper;
using Student.Management.System.Domain.Entities.DTOs;

namespace Student.Management.System.Application{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentModel,GetStudentDto>();
            CreateMap<AddStudentDto,StudentModel>();
            CreateMap<UpdateStudentDto,StudentModel>();
        }
    }
}