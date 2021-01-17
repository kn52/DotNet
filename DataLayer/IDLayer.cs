namespace DataLayer
{
    using EmpLayer;
    using System.Collections.Generic;
    public interface IDLayer
    {
        IEnumerable<Emp> GetAllEmployees();
        string AddEmployee(Emp emp);
        string EncodeDecodePassword(string password);
        string GenerateJSONWebToken();
        bool ValidateJSONWebToken(string token);
    }
}
