using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace SourcecastReportsApi.Models
{
    public class StateJobInfoData
    {
        public List<string> GetStatusList()
        {

           var statusus =
                new List<string> {"stateJobID", "onlineStateJobUrl", "notAvailable", "rejected", ""};

            return statusus;
        }

        public DataTable GetJcJobIds()
        {
            DataSet ds = new DataSet();
            string connectionString = GetConnectionString("vet");
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                OracleCommand cmd =
                    new OracleCommand("SELECT JC_JOB_ID,STATE FROM JOB_DATA WHERE ROWNUM <=10000", con)
                    {
                        CommandType = CommandType.Text,
                        BindByName = true
                    };

                OracleDataAdapter da = new OracleDataAdapter {SelectCommand = cmd};

                da.Fill(ds);
            }

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            return ds.Tables[0];
        }

        private string GetConnectionString(string type)
        {
            switch (type)
            {
                case "vet":
                    return ConfigurationManager.ConnectionStrings["VetConStr"].ConnectionString;

                case "voc":
                    return ConfigurationManager.ConnectionStrings["VocConStr"].ConnectionString;

                case "va":
                    return ""; //TODO
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

    }

    public class StateJobInfoDataFields
    {
        public string jobID { get; set; }

        public string stateJobID = "123456";

        public string state { get; set; }

        public string onlineStateJobUrl = "";

        public string status = "stateJobID";

    }

}