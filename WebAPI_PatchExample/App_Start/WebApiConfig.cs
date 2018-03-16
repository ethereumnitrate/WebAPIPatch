using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_PatchExample.Common;

namespace WebAPI_PatchExample
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

            config.ParameterBindingRules.Insert(0, descriptor =>
                           typeof(IPatchState).IsAssignableFrom(descriptor.ParameterType)
                           ? new PatchBinding(descriptor)
                           : null);
        }
    }
}
