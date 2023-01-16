using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Management.System.Domain.Entities
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; }=string.Empty;
        public string MiddleName { get; set; } =string.Empty;
        public DateTime DateOfBirth { get; set; }
        public virtual Subject? FavoriteSubject { get; set; }

        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }
    }
}