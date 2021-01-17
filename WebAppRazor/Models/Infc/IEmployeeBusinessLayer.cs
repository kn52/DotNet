using System.Collections.Generic;

namespace WebAppRazor.Models.Infc
{
    public interface IEmployeeBusinessLayer
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        string AddEmloyee(Employee employee);
        string UpdateEmloyee(int id, Employee employee);
        string DeleteEmloyee(int id);
    }
}
