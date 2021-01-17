namespace RepoLayer
{
    using EmpLayer;
    using System.Collections.Generic;

    public interface IRLayer
    {
        IEnumerable<Emp> GetAllEmployees();

        string AddEmployee(Emp emp);
        string GenerateJSONWebToken();
        string EncodeDecodePassword(string password);
        bool ValidateJSONWebToken(string token);
    }
}
