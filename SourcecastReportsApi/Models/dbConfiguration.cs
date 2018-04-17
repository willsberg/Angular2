using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SourcecastReportsApi.Models
{
    public static class DbConfiguration
    {
        public static string VetcentralConfiguration = ConfigurationManager.ConnectionStrings["VetConStr"].ConnectionString;
        public static string VoccentralConfiguration = ConfigurationManager.ConnectionStrings["VocConStr"].ConnectionString;
    }
}