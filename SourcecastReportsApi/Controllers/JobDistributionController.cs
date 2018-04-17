using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Oracle.DataAccess.Client;
using SourcecastReportsApi.Models;

namespace SourcecastReportsApi.Controllers
{
    public class JobDistributionController : ApiController
    {

        public JobDistributionReport GetDistributionDetails(string sourcetype)
        {
            DbSourcecastType sbSourceType;
            Enum.TryParse(sourcetype, true, out sbSourceType);
            JobDistributionReport jdreport = new JobDistributionReport();

           
            OracleDataReader dr = null;
            string connectionString = GetConnectionString(sbSourceType);
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                OracleCommand cmd =
                    new OracleCommand("Package_Notification.prc_get_scheduled_task_stat", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        BindByName = true
                    };

                cmd.Parameters.Add("p_date", DateTime.Now.AddDays(-1));
                cmd.Parameters.Add("p_cutOffHour", 12);
                cmd.Parameters.Add("p_refcursor", OracleDbType.RefCursor, ParameterDirection.Output);
                con.Open();

                try
                {
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        jdreport.EmailjobdistributionTotal = dr["p_EmailjobdistributionTotal"].ToString();
                        jdreport.EmailjobdistributionMax = dr["p_EmailjobdistributionMax"].ToString();
                        jdreport.EmailjobdistributionMin = dr["p_EmailjobdistributionMin"].ToString();
                        jdreport.EmailjobdistributionProblem = dr["p_EmailjobdistributionProblem"].ToString();
                        jdreport.EmailjobDistributionRunningStatus = dr["p_running_EmailjobDistribution"].ToString();

                        jdreport.FaxjobdistributionTotal = dr["p_FaxjobdistributionTotal"].ToString();
                        jdreport.FaxjobdistributionMax = dr["p_FaxjobdistributionMax"].ToString();
                        jdreport.FaxjobdistributionMin = dr["p_FaxjobdistributionMin"].ToString();
                        jdreport.FaxjobdistributionProblem = dr["p_FaxjobdistributionProblem"].ToString();
                        jdreport.FaxjobDistributionRunningStatus = dr["p_running_FaxjobDistribution"].ToString();

                        jdreport.AssociatedEmailjobdistributionTotal = dr["assoEmailDistributionTotal"].ToString();
                        jdreport.AssociatedEmailjobdistributionMax = dr["assoEmailDistributionMax"].ToString();
                        jdreport.AssociatedEmailjobdistributionMin = dr["assoEmailDistributionMin"].ToString();
                        jdreport.AssociatedEmailjobdistributionProblem = dr["assoEmailDistributionProblem"].ToString();
                        jdreport.AssociatedEmailjobdistributionRunningStatus = dr["runningAssoEmailDistribution"].ToString();

                        jdreport.AssociatedFaxdistributionTotal = dr["assoFaxDistributionTotal"].ToString();
                        jdreport.AssociatedFaxdistributionMax = dr["assoFaxDistributionMax"].ToString();
                        jdreport.AssociatedFaxdistributionMin = dr["assoFaxDistributionMin"].ToString();
                        jdreport.AssociatedFaxdistributionProblem = dr["assoFaxDistributionProblem"].ToString();
                        jdreport.AssociatedFaxdistributionRunningStatus = dr["runningAssoFaxDistribution"].ToString();

                        jdreport.BouncedTotal = dr["bouncedTotal"].ToString();
                        jdreport.BouncedMax = dr["bouncedMax"].ToString();
                        jdreport.BouncedMin = dr["bouncedMin"].ToString();
                        jdreport.BouncedProblem = dr["bouncedProblem"].ToString();
                        jdreport.RunningBounced = dr["running_bounced"].ToString();

                        jdreport.ReDistributionTotal = dr["reDistributionTotal"].ToString();
                        jdreport.ReDistributionMax = dr["reDistributionMax"].ToString();
                        jdreport.ReDistributionMin = dr["reDistributionMin"].ToString();
                        jdreport.ReDistributionProblem = dr["reDistributionProblem"].ToString();
                        jdreport.RunningReDistribution = dr["running_reDistribution"].ToString();

                        jdreport.FaxConfirmTotal = dr["faxConfirmTotal"].ToString();
                        jdreport.FaxConfirmMax = dr["faxConfirmMax"].ToString();
                        jdreport.FaxConfirmMin = dr["faxConfirmMin"].ToString();
                        jdreport.FaxConfirmProblem = dr["faxConfirmProblem"].ToString();
                        jdreport.RunningFaxConChecker = dr["running_faxConChecker"].ToString();

                        jdreport.ManualupdateTotal = dr["manualupdateTotal"].ToString();
                        jdreport.ManualupdateMax = dr["manualupdateMax"].ToString();
                        jdreport.ManualupdateMin = dr["manualupdateMin"].ToString();
                        jdreport.ManualupdateProblem = dr["manualupdateProblem"].ToString();
                        jdreport.RunningManualUpdate = dr["running_manual_update"].ToString();

                        jdreport.JobDistNotificationTotal = dr["jobDistNotificationTotal"].ToString();
                        jdreport.JobDistNotificationMax = dr["jobDistNotificationMax"].ToString();
                        jdreport.JobDistNotificationMin = dr["jobDistNotificationMin"].ToString();
                        jdreport.JobDistNotificationProblem = dr["jobDistNotificationProblem"].ToString();
                        jdreport.RunningJobDistNotification = "No";

                        //2nd Table: Job Distribution Report

                        jdreport.TotalJobDis = dr["totalJobDis"].ToString();
                        jdreport.TotalStateDis = dr["totalStateDis"].ToString();
                        jdreport.TotalCenterDis = dr["totalCenterDis"].ToString();
                        jdreport.TotalOldest = dr["totalOldest"].ToString();

                        jdreport.TotalviaEmail = dr["totalviaEmail"].ToString();
                        jdreport.TotalStateViaEmail = dr["totalStateViaEmail"].ToString();
                        jdreport.TotalCenterviaEmail = dr["totalCenterviaEmail"].ToString();
                        jdreport.EmailOldest = dr["emailOldest"].ToString();

                        jdreport.TotalviaFax = dr["totalviaFax"].ToString();
                        jdreport.TotalStateViaFax = dr["totalStateViaFax"].ToString();
                        jdreport.TotalCenterviaFax = dr["totalCenterviaFax"].ToString();
                        jdreport.FaxOldest = dr["faxOldest"].ToString();

                        jdreport.TotalViaMail = dr["totalViaMail"].ToString();
                        jdreport.TotalStateViaMail = dr["totalStateViaMail"].ToString();
                        jdreport.TotalCenterViaMail = dr["totalCenterViaMail"].ToString();
                        jdreport.MailOldest = dr["mailOldest"].ToString();

                        jdreport.TotalPrinted = dr["totalPrinted"].ToString();
                        jdreport.TotalStatePrinted = dr["totalStatePrinted"].ToString();
                        jdreport.TotalCenterPrinted = dr["totalCenterPrinted"].ToString();
                        jdreport.PrintedOldest = dr["printedOldest"].ToString();

                        jdreport.TotalUndelivered = dr["total_undelivered"].ToString();
                        jdreport.TotalStateUndelivered = dr["totalStateUndelivered"].ToString();
                        jdreport.TotalCenterUndelivered = dr["totalCenterUndelivered"].ToString();
                        jdreport.UndeliveredOldestDate = dr["undelivered_oldest_date"].ToString();

                        jdreport.TotalNotSent = dr["total_notSent"].ToString();
                        jdreport.TotalStateNotSent = dr["totalState_notSent"].ToString();
                        jdreport.PNotSentOldestDate = dr["p_notSent_oldest_date"].ToString();

                        jdreport.BouncedWithProblem = dr["BouncedWithProblem"].ToString();

                        jdreport.TotalAdHocRpt = dr["totalAdHocRpt"].ToString();

                        //3nd table

                        jdreport.TotalJobsSentAll = dr["totalJobDis"].ToString();
                        jdreport.TotalEmailSent = dr["totalEmailSent"].ToString();
                        jdreport.TotalFaxSent = dr["totalFaxSent"].ToString();
                        jdreport.TotalMailSent = dr["totalMailSent"].ToString();
                       

                        jdreport.TotalConfirmed = dr["total_confirmed"].ToString();
                        jdreport.Econfirmed = dr["Econfirmed"].ToString();
                        jdreport.Fconfirmed = dr["Fconfirmed"].ToString();
                        jdreport.Mconfirmed = dr["Mconfirmed"].ToString();

                        jdreport.TotalBounced = dr["total_bounced"].ToString();
                        jdreport.BouncedEmail = dr["bounced_email"].ToString();
                        jdreport.BouncedFax = dr["bounced_fax"].ToString();
                        jdreport.BouncedMail = dr["bounced_mail"].ToString();

                        jdreport.TotalLateBounced = dr["totalLateBounced"].ToString();
                        jdreport.EmailLateBounced = dr["emailLateBounced"].ToString();
                        jdreport.FaxLateBounced = dr["faxLateBounced"].ToString();
                        jdreport.MailLateBounced = dr["mailLateBounced"].ToString();

                    }
                }
                catch (Exception ex)
                {
                   
                }


            }

            return jdreport;
        }


        private string GetConnectionString(DbSourcecastType type)
        {
            switch (type)
            {
                case DbSourcecastType.Vet:
                    return ConfigurationManager.ConnectionStrings["VetConStr"].ConnectionString;

                case DbSourcecastType.Voc:
                    return ConfigurationManager.ConnectionStrings["VocConStr"].ConnectionString;

                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

        public StatusCountAll GetOtherDetails(string sourcetype)
        {
            DataSet ds = new DataSet();
            DbSourcecastType sbSourceType;
            Enum.TryParse(sourcetype, true, out sbSourceType);
            string connectionString = GetConnectionString(sbSourceType);

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                OracleCommand cmd =
                    new OracleCommand("Package_Notification.prc_get_count_by_status", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        BindByName = true
                    };

                cmd.Parameters.Add("p_refcursor_current", OracleDbType.RefCursor, ParameterDirection.Output);
                cmd.Parameters.Add("p_refcursor_prev", OracleDbType.RefCursor, ParameterDirection.Output);
                cmd.Parameters.Add("p_refcursor_sinceJuly07", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataAdapter da = new OracleDataAdapter {SelectCommand = cmd};

                da.Fill(ds);
            }
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            var statusCountAll = new StatusCountAll
            {
                Current = new List<JobCountByStatusCurrent>(),
                Previous = new List<JobCountByStatusPrevious>(),
                Old = new List<JobCountByStatusOld>()
            };
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var current = new JobCountByStatusCurrent
                {
                    Status = row["SENT_TO_OSC_STATUS"].ToString(),
                    Count = row["TOTAL"].ToString()
                };

                statusCountAll.Current.Add(current);
            }
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                var prev = new JobCountByStatusPrevious
                {
                    Status = row["SENT_TO_OSC_STATUS"].ToString(),
                    Count = row["TOTAL"].ToString()
                };

                statusCountAll.Previous.Add(prev);
            }
            foreach (DataRow row in ds.Tables[2].Rows)
            {
                var old = new JobCountByStatusOld
                {
                    Status = row["SENT_TO_OSC_STATUS"].ToString(),
                    Count = row["TOTAL"].ToString()
                };

                statusCountAll.Old.Add(old);
            }
            return statusCountAll;
        }
       
    }
}
