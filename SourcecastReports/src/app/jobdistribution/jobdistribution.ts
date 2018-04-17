export interface IJobDistribution {

    EmailjobdistributionTotal: string,
    EmailjobdistributionMax: string,
    EmailjobdistributionMin: string,
    EmailjobdistributionProblem: string,
    EmailjobDistributionRunningStatus: string,
    FaxjobdistributionTotal: string,
    FaxjobdistributionMax: string,
    FaxjobdistributionMin: string,
    FaxjobdistributionProblem: string,
    FaxjobDistributionRunningStatus: string,
    AssociatedEmailjobdistributionTotal: string,
    AssociatedEmailjobdistributionMax: string,
    AssociatedEmailjobdistributionMin: string,
    AssociatedEmailjobdistributionProblem: string,
    AssociatedEmailjobdistributionRunningStatus: string;
    AssociatedFaxdistributionTotal: string;
    AssociatedFaxdistributionMax: string;
    AssociatedFaxdistributionMin: string;
    AssociatedFaxdistributionProblem: string;
    AssociatedFaxdistributionRunningStatus: string;
    BouncedTotal: string;
    BouncedMax: string;
    BouncedMin: string;
    BouncedProblem: string;
    RunningBounced: string;
    ReDistributionTotal: string;
    ReDistributionMax: string;
    ReDistributionMin: string;
    ReDistributionProblem: string;
    RunningReDistribution: string;
    FaxConfirmTotal: string;
    FaxConfirmMax: string;
    FaxConfirmMin: string;
    FaxConfirmProblem: string;
    RunningFaxConChecker: string;
    ManualupdateTotal: string;
    ManualupdateMax: string;
    ManualupdateMin: string;
    ManualupdateProblem: string;
    RunningManualUpdate: string;
    JobDistNotificationTotal: string;
    JobDistNotificationMax: string;
    JobDistNotificationMin: string;
    JobDistNotificationProblem: string;
    RunningJobDistNotification: string;

    //

    TotalJobDis: string;
    TotalStateDis: string;
    TotalCenterDis: string;
    TotalOldest: string;

    TotalviaEmail: string;
    TotalStateViaEmail: string;
    TotalCenterviaEmail: string;
    EmailOldest: string;

    TotalviaFax: string;
    TotalStateViaFax: string;
    TotalCenterviaFax: string;
    FaxOldest: string;

    TotalViaMail: string;
    TotalStateViaMail: string;
    TotalCenterViaMail: string;
    MailOldest: string;


    TotalPrinted: string;
    TotalStatePrinted: string;
    TotalCenterPrinted: string;
    PrintedOldest: string;

    TotalUndelivered: string;
    TotalStateUndelivered: string;
    TotalCenterUndelivered: string;
    UndeliveredOldestDate: string;

    TotalNotSent: string;
    TotalStateNotSent: string;
    PNotSentOldestDate: string;

    BouncedWithProblem: string;
    TotalAdHocRpt: string;


    //3nd Table: JOb Distribution Report
    TotalJobsSentAll: string;
    TotalEmailSent: string;
    TotalFaxSent: string;
    TotalMailSent: string;

    TotalConfirmed: string;
    Econfirmed: string;
    Mconfirmed: string;
    Fconfirmed: string;

    TotalBounced: string;
    BouncedEmail: string;
    BouncedFax: string;
    BouncedMail: string;

    TotalLateBounced: string;
    EmailLateBounced: string;
    FaxLateBounced: string;
    MailLateBounced: string;



}

export interface IStatus {
    Current: CurrentStatus;
    Previous: PreviousStatus;
    Old: OldStatus;

}

export class CurrentStatus {
    JobCountByStatusCurrent: any[];

}
export class PreviousStatus {
    JobCountByStatusPrevious: any[];

}
export class OldStatus {
    JobCountByStatusOld: any[];

}
