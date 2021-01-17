using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiMvc.Models;

namespace WebApiMvc.Controllers
{
   [EnableCors(origins:"*", headers:"*", methods:"*",exposedHeaders:"My-Header")]
    public class EmployeeController : ApiController
    {
        // GET api/<controller>
        [HttpGet,Route("employee")]
        public HttpResponseMessage GetEmployees(string Gender = "All" )
        {
            //string username = Thread.CurrentPrincipal.Identity.Name;
            string username = "";
            using (EmployeeDbContext dbContext = new EmployeeDbContext())
            {

                var entity = dbContext.Employees.ToList();
                if(entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,"");
                }
                switch (username.ToLower())
                {
                    case "male":
                        return Request.CreateResponse(HttpStatusCode.OK,
                            entity.Where(e => e.Gender.ToLower() == "male").ToList());
                    case "female":
                        return Request.CreateResponse(HttpStatusCode.OK,
                            entity.Where(e => e.Gender.ToLower() == "female").ToList());
                    default:
                        return Request.CreateResponse(HttpStatusCode.OK,entity);
                }
            }
        }

        // GET api/<controller>/5
        [HttpGet,Route("employee/{id}")]
        public HttpResponseMessage GetEmplyeeById(int id)
        {
            using (EmployeeDbContext dbContext = new EmployeeDbContext())
            {
                var entity = dbContext.Employees.FirstOrDefault(employee => employee.Id == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "");
                }
                return Request.CreateResponse(HttpStatusCode.OK, entity);
            }
        }

        // POST api/<controller>
        [HttpPost, Route("employee")]
        public HttpResponseMessage AddEmployee([FromBody] Employee employee)
        {
            using (EmployeeDbContext dbContext = new EmployeeDbContext())
            {
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Added Successfully");
            }
        }

        // PUT api/<controller>/5
        [HttpPut, Route("employee")]
        public HttpResponseMessage EditEmployee(int id, [FromBody]Employee employee)
        {
            using (EmployeeDbContext dbContext = new EmployeeDbContext())
            {
                var entity = dbContext.Employees.FirstOrDefault(emp => emp.Id == id );
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "");
                }
                entity.FName = employee.FName;
                entity.LName = employee.LName;
                entity.Email = employee.Email;
                employee.Password = employee.Password;
                employee.PhoneNumber = employee.PhoneNumber;
                dbContext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Updated Successfully");
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete, Route("employee/{id}")]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            using (EmployeeDbContext dbContext = new EmployeeDbContext())
            {
                var entity = dbContext.Employees.FirstOrDefault(employee => employee.Id == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "");
                }
                dbContext.Employees.Remove(entity);
                dbContext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted Successfully");
            }
        }
    }
}