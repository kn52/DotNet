namespace WebApiDemo
{
    using DataLayer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("webapi")]
    
    public class TokenController : Controller
    {
        public TokenController(IDLayer ops)
        {
            this.Service = ops;
        }

        public IDLayer Service { get; set; }

        [HttpGet]
        [Route("generatetoken")]
        public string GetToken()
        {
            return Service.GenerateJSONWebToken();
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        [Route("validatetoken")]
        public bool ValidateToken([FromQuery]string token)
        {
            return Service.ValidateJSONWebToken(token);
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        [Route("getrole")]
        public string getRole()
        {
            string s = User.FindFirst("user").Value;
            return s;
        }
    }
}