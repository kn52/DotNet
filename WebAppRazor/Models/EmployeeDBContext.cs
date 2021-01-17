using Microsoft.EntityFrameworkCore;

namespace WebAppRazor.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { set; get; }
    }
}
