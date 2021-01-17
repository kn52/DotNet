using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiMvc.Models;

namespace WebApiMvc
{
    public class EmployeeSecurity
    {
        public static bool Login(string email,string password)
        {
            using (EmployeeDbContext dbContext = new EmployeeDbContext())
            {
                return dbContext.Employees.Any(e => e.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                    && e.Password.Equals(password));
            }
        }
    }
}