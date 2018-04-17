using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace SourcecastReportsApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "JobDistributionApi",
                routeTemplate: "api/Jd/{sourcetype}/{id}",
                defaults: new { Controller = "JobDistribution", Action = "GetDistributionDetails", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetJobDataApi",
                routeTemplate: "api/statedata/{stateJobId}",
                defaults: new { Controller = "StateJobData", Action = "GetJobData" }
            );

            config.Routes.MapHttpRoute(
                name: "JobDistributionApi2",
                routeTemplate: "api/Jd2/{sourcetype}/statuscpo",
                defaults: new { Controller = "JobDistribution", Action = "GetOtherDetails"}
            );
        }
    }
}
