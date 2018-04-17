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
var JobDistributionVocComponent = /** @class */ (function () {
    function JobDistributionVocComponent(jobDistService) {
        this.jobDistService = jobDistService;
    }
    JobDistributionVocComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.jobDistService.geVocDistributionDetails()
            .subscribe(function (jobdistributionData) { return _this.data = jobdistributionData; });
    };
    JobDistributionVocComponent = __decorate([
        core_1.Component({
            selector: "job-dist-voc",
            templateUrl: "app/jobdistribution/jobdistribution.component.html",
            providers: [JobDistributionService]
        }),
        __metadata("design:paramtypes", [JobDistributionService])
    ], JobDistributionVocComponent);
    return JobDistributionVocComponent;
}());
exports.JobDistributionVocComponent = JobDistributionVocComponent;
//# sourceMappingURL=jobdistributionVoc.component..js.map