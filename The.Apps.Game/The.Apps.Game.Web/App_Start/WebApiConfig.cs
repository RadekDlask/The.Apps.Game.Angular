using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace The.Apps.Game.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
#if (DEBUG)
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
#endif
            // Let's configure a json respones format.
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

#if (DEBUG)
            // We like to have a pretty json responses for debugging purposses.
            jsonFormatter.Indent = true;
#endif
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
