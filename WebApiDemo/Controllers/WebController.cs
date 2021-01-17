using System.Collections.Generic;
using DataLayer;
using EmpLayer;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebController : ControllerBase
    {
        public WebController(IDLayer ops) 
        {
            this.Service = ops;
        }

        public IDLayer Service { get; set; }

        // GET api/values
        [HttpGet]
        [Route("getallemployees")]
        public IEnumerable<Emp> Get()
        {
            return this.Service.GetAllEmployees();
        }
    }
}
