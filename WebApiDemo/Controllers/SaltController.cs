namespace WebApiDemo.Controllers
{
    using System.Collections.Generic;
    using DataLayer;
    using EmpLayer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class SaltController : Controller
    {
        public SaltController(IDLayer ops)
        {
            this.Service = ops;
        }

        public IDLayer Service { get; set; }

        [HttpGet]
        public string Get([FromQuery]string id)
        {
            return Service.EncodeDecodePassword(id);
        }

        // POST api/<controller>
        [HttpPost]
        public string AddEmployee([FromBody]Emp emp)
        {
            return this.Service.AddEmployee(emp);
        }
    }
}
