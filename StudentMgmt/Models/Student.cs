using System.ComponentModel.DataAnnotations.Schema;

namespace StudentMgmt.Models
{
    [Table("Student")]
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
    }
}