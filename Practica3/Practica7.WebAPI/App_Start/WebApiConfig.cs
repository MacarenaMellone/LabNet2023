using System.Web.Http;
using System.Web.Http.Cors;

namespace Practica7.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //CORS
            var cors = new EnableCorsAttribute("https://localhost:4200", "*", "*");
            config.EnableCors(cors);
        }
    }
}
