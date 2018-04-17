"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var Jobdistributionservice = require("./jobdistribution.service");
var JobDistributionService = Jobdistributionservice.JobDistributionService;
var JobDistributionComponent = /** @class */ (function () {
    function JobDistributionComponent(jobDistService) {
        this.jobDistService = jobDistService;
        this.title = 'Distribution Summary Report for the Last 24 hours.';
    }
    JobDistributionComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.jobDistService.geVetDistributionDetails()
            .subscribe(function (jobdistributionData) { return _this.data = jobdistributionData; });
        this.jobDistService.geVetStatusCount()
            .subscribe(function (statusData) { return _this.status = statusData; });
        this.currentDate = this.getCurrentMonth();
        this.previousDate = this.getPreviousMonth();
    };
    JobDistributionComponent.prototype.getCurrentMonth = function () {
        var monthNames = ["January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        ];
        var dyear = new Date();
        return monthNames[dyear.getMonth()] + ' ' + dyear.getFullYear() + ' Jobs';
    };
    JobDistributionComponent.prototype.getPreviousMonth = function () {
        var monthNames = ["January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        ];
        var dyear = new Date();
        return monthNames[dyear.getMonth() - 1] + ' ' + dyear.getFullYear() + ' Jobs';
    };
    JobDistributionComponent = __decorate([
        core_1.Component({
            selector: "job-dist",
            templateUrl: "app/jobdistribution/jobdistribution.component.html",
            providers: [JobDistributionService]
        }),
        __metadata("design:paramtypes", [JobDistributionService])
    ], JobDistributionComponent);
    return JobDistributionComponent;
}());
exports.JobDistributionComponent = JobDistributionComponent;
//# sourceMappingURL=jobdistribution.component.js.map