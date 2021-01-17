using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        public RabbitController(IRabbitMQService ops)
        {
            this.Service = ops;
        }

        public IRabbitMQService Service { get; set; }

        // GET: api/<RabbitController>
        [HttpPost("sendMessage")]
        public string SendMessage([FromQuery]string msg)
        {
            Console.WriteLine();
            var result = Service.PublishRabbitMQ(msg);
            return result;
        }
    }
}
