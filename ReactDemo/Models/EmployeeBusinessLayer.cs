using ReactDemo.Models.Infc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ReactDemo.Models
{
    public class EmployeeBusinessLayer : IEmployeeBusinessLayer
    {
        public EmployeeBusinessLayer(EmployeeDBContext employeeDBContext)
        {
            this.dbContext = employeeDBContext;
        }

        public EmployeeDBContext dbContext { get; set; }

        public string AddEmloyee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return "Added Successfully";
        }

        public string DeleteEmloyee(int id)
        {
            var entity = dbContext.Employees.FirstOrDefault(e => e.Id == id);
            if (entity == null)
            {
                return "Employee Not Found";
            }
            dbContext.Employees.Remove(entity);
            dbContext.SaveChanges();
            return "Deleted Successfully";
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var entity = dbContext.Employees.Select(x=>x).ToList();
            return entity;
        }

        public Employee GetEmployeeById(int id)
        {
            var entity = dbContext.Employees.FirstOrDefault(e => e.Id == id);
            return entity;
        }

        public string UpdateEmloyee(int id,Employee employee)
        {
            var entity = dbContext.Employees.FirstOrDefault(emp => emp.Id == id);
            if (entity == null)
            {
                return "Employee Not Found";
            }
            dbContext.Entry(entity).State = EntityState.Modified;
            //entity.FirstName = employee.FirstName;
            //entity.LastName = employee.LastName;
            //entity.Email = employee.Email;
            //employee.Password = employee.Password;
            //employee.PhoneNumber = employee.PhoneNumber;
            dbContext.SaveChanges();
            return "Updated Successfully";
        }
    }
}
