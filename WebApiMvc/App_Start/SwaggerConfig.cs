using System.Web.Http;
using WebActivatorEx;
using WebApiMvc;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApiMvc
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "WebApiMvc");
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}