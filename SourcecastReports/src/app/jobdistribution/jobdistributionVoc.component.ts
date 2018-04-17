import { Component,OnInit } from '@angular/core';
import Jobdistribution = require("./jobdistribution");
import IJobDistribution = Jobdistribution.IJobDistribution;
import Jobdistributionservice = require("./jobdistribution.service");
import JobDistributionService = Jobdistributionservice.JobDistributionService;
import IStatus = Jobdistribution.IStatus;

@
Component({
    selector: "job-dist-voc",
    templateUrl: "app/jobdistribution/jobdistribution.component.html",
    providers: [JobDistributionService]

})
export class JobDistributionVocComponent implements OnInit{

    data: IJobDistribution;
    status: IStatus;
    title = 'Distribution Summary Report for the Last 24 hours.';
    currentDate: string;
    previousDate: string;
    
    constructor(private jobDistService: JobDistributionService)
    {
        
    }

    ngOnInit() {

        this.jobDistService.geVocDistributionDetails()
            .subscribe((jobdistributionData) => this.data = jobdistributionData);

        this.jobDistService.geVocStatusCount()
            .subscribe((statusData) => this.status = statusData);

        this.currentDate = this.getCurrentMonth();
        this.previousDate = this.getPreviousMonth();
    }

    private getCurrentMonth(): string {

        var monthNames = ["January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        ];

        const dyear: Date = new Date();
        return monthNames[dyear.getMonth()] + ' ' + dyear.getFullYear() + ' Jobs';
    }

    private getPreviousMonth(): string {

        var monthNames = ["January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        ];

        const dyear: Date = new Date();
        return monthNames[dyear.getMonth() - 1] + ' ' + dyear.getFullYear() + ' Jobs';
    }

}