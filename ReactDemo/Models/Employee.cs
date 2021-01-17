using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactDemo.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("FName")]
        public string FirstName { get; set; }
        [Column("LName")]
        public string LastName { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("Gender")]
        public string Gender { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Column("keyNew")]
        public string KeyNew { get; set; }
    }
}
