namespace Student.Management.System.Domain.Entities.DTOs
{
    public class UpdateStudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; }=string.Empty;
        public string MiddleName { get; set; } =string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int SubjectId { get; set; }
    }
}