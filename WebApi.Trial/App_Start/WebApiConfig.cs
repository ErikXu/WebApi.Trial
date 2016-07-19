using System.Web.Http;
using WebApi.Trial.Common.Filters;

namespace WebApi.Trial
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional } );

            //register the custom action filter
            config.Filters.Add(new GlobalActionFilterAttribute());
        }
    }
}
