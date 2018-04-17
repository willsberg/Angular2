using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SourcecastReportsApi.Models
{
    public class JobDistributionReport
    {
        public string EmailjobdistributionTotal { get; set; }
        public string EmailjobdistributionMax { get; set; }
        public string EmailjobdistributionMin { get; set; }
        public string EmailjobdistributionProblem { get; set; }
        public string EmailjobDistributionRunningStatus { get; set; }
        public string FaxjobdistributionTotal { get; set; }
        public string FaxjobdistributionMax { get; set; }
        public string FaxjobdistributionMin { get; set; }
        public string FaxjobdistributionProblem { get; set; }
        public string FaxjobDistributionRunningStatus { get; set; }
        public string AssociatedEmailjobdistributionTotal { get; set; }
        public string AssociatedEmailjobdistributionMax { get; set; }
        public string AssociatedEmailjobdistributionMin { get; set; }
        public string AssociatedEmailjobdistributionProblem { get; set; }
        public string AssociatedEmailjobdistributionRunningStatus { get; set; }
        public string AssociatedFaxdistributionTotal { get; set; }
        public string AssociatedFaxdistributionMax { get; set; }
        public string AssociatedFaxdistributionMin { get; set; }
        public string AssociatedFaxdistributionProblem { get; set; }
        public string AssociatedFaxdistributionRunningStatus { get; set; }

        public string BouncedTotal { get; set; }
        public string BouncedMax { get; set; }
        public string BouncedMin { get; set; }
        public string BouncedProblem { get; set; }
        public string RunningBounced { get; set; }

        public string ReDistributionTotal { get; set; }
        public string ReDistributionMax { get; set; }
        public string ReDistributionMin { get; set; }
        public string ReDistributionProblem { get; set; }
        public string RunningReDistribution { get; set; }

        public string FaxConfirmTotal { get; set; }
        public string FaxConfirmMax { get; set; }
        public string FaxConfirmMin { get; set; }
        public string FaxConfirmProblem { get; set; }
        public string RunningFaxConChecker { get; set; }

        public string ManualupdateTotal { get; set; }
        public string ManualupdateMax { get; set; }
        public string ManualupdateMin { get; set; }
        public string ManualupdateProblem { get; set; }
        public string RunningManualUpdate { get; set; }

        public string JobDistNotificationTotal { get; set; }
        public string JobDistNotificationMax { get; set; }
        public string JobDistNotificationMin { get; set; }
        public string JobDistNotificationProblem { get; set; }
        public string RunningJobDistNotification { get; set; }

        //2nd Table
        public string TotalJobDis { get; set; }
        public string TotalStateDis { get; set; }
        public string TotalCenterDis { get; set; }
        public string TotalOldest { get; set; }

        public string TotalviaEmail { get; set; }
        public string TotalStateViaEmail { get; set; }
        public string TotalCenterviaEmail { get; set; }
        public string EmailOldest { get; set; }

        public string TotalviaFax { get; set; }
        public string TotalStateViaFax { get; set; }
        public string TotalCenterviaFax { get; set; }
        public string FaxOldest { get; set; }

        public string TotalViaMail { get; set; }
        public string TotalStateViaMail { get; set; }
        public string TotalCenterViaMail { get; set; }
        public string MailOldest { get; set; }


        public string TotalPrinted { get; set; }
        public string TotalStatePrinted { get; set; }
        public string TotalCenterPrinted { get; set; }
        public string PrintedOldest { get; set; }

        public string TotalUndelivered { get; set; }
        public string TotalStateUndelivered { get; set; }
        public string TotalCenterUndelivered { get; set; }
        public string UndeliveredOldestDate { get; set; }

        public string TotalNotSent { get; set; }
        public string TotalStateNotSent { get; set; }
        public string PNotSentOldestDate { get; set; }

        public string BouncedWithProblem { get; set; }
        public string TotalAdHocRpt { get; set; }


        //3nd Table: JOb Distribution Report
        public string TotalJobsSentAll { get; set; }

        public string TotalEmailSent { get; set; }
        public string TotalFaxSent { get; set; }
        public string TotalMailSent { get; set; }

        public string TotalConfirmed { get; set; }
        public string Econfirmed { get; set; }
        public string Mconfirmed { get; set; }

        public string Fconfirmed { get; set; }

        public string TotalBounced { get; set; }
        public string BouncedEmail { get; set; }
        public string BouncedFax { get; set; }
        public string BouncedMail { get; set; }

        public string TotalLateBounced { get; set; }
        public string EmailLateBounced { get; set; }
        public string FaxLateBounced { get; set; }
        public string MailLateBounced { get; set; }


    }

    public class StatusCountAll
    {

        public List<JobCountByStatusCurrent> Current;
        public List<JobCountByStatusPrevious> Previous;
        public List<JobCountByStatusOld> Old;

    }
    public class JobCountByStatusCurrent
    {
        public string Status { get; set; }
        public string Count { get; set; }

    }
    public class JobCountByStatusPrevious
    {
        public string Status { get; set; }
        public string Count { get; set; }

    }
    public class JobCountByStatusOld
    {
        public string Status { get; set; }
        public string Count { get; set; }

    }
}