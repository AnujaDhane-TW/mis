using Microsoft.AspNetCore.Mvc;
using Moq;
using Student.Management.System.Application.Ports.In;
using Student.Management.System.Domain.Entities;
using Student.Management.System.WebAPI.Controllers;


namespace Student.Management.System.Tests.WebAPI
{
    public class StudentControllerTest
    {
        private readonly Mock<IStudentService> mockStudentService;
        
        private readonly StudentController studentController;
        public StudentControllerTest()
        {
            mockStudentService = new Mock<IStudentService>();
            studentController = new StudentController(mockStudentService.Object);
        }

        // [Fact]
        // public void ShouldReturnListOfStudentsWhenGetIsCalled(){
            
        //     mockStudentService.Setup(service => service.GetStudents())
        //         .Returns(new List<StudentModel>() { new StudentModel(), new StudentModel() });
        //     ActionResult<List<StudentModel>> actionResult = studentController.GetStudents();
            
        //     // var result = _controller.Index();
        //     var viewResult = Assert.IsType<ActionResult<List<StudentModel>>>(actionResult);
        //     var students = Assert.IsType<List<StudentModel>>(((OkObjectResult)(actionResult.Result)).Value);
        //     List<StudentModel> expectedStudents= new List<StudentModel>() { new StudentModel(), new StudentModel() };

        //     //Assert.Equal(expectedStudents,students);

        //     }
    }

  
}