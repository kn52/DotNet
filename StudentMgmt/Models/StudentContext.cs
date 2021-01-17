using System.Data.Entity;

namespace StudentMgmt.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}