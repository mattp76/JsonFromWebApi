using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using JsonFromWebApi.Helpers;
using System.Net.Http.Formatting;

namespace JsonFromWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute("CustomApi", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional });

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            
            var jsonFormatter = new JsonMediaTypeFormatter();


            config.Services.Replace(
                typeof(IContentNegotiator),
                new AlwaysJsonContent(jsonFormatter));



            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // To disable tracing in your application, please comment out or remove the following line of code
            // For more information, refer to: http://www.asp.net/web-api
            config.EnableSystemDiagnosticsTracing();

            config.Formatters.Clear();
            //config.Formatters.Add(new JsonMediaTypeFormatter());
        }
    }
}
