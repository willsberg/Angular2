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
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
//Use Injectable decorator imported from core.
var JobDistributionService = /** @class */ (function () {
    function JobDistributionService(http) {
        this.http = http;
    }
    JobDistributionService.prototype.geVetDistributionDetails = function () {
        return this.http.get("http://172.16.0.225:85/api/jd/vet").
            map(function (response) { return response.json(); });
    };
    JobDistributionService.prototype.geVetStatusCount = function () {
        return this.http.get("http://172.16.0.225:85/api/jd2/vet/statuscpo").
            map(function (response) { return response.json(); });
    };
    JobDistributionService.prototype.geVocDistributionDetails = function () {
        return this.http.get("http://172.16.0.225:85/api/jd/voc").
            map(function (response) { return response.json(); });
    };
    JobDistributionService.prototype.geVocStatusCount = function () {
        return this.http.get("http://172.16.0.225:85/api/jd2/voc/statuscpo").
            map(function (response) { return response.json(); });
    };
    JobDistributionService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http])
    ], JobDistributionService);
    return JobDistributionService;
}());
exports.JobDistributionService = JobDistributionService;
//# sourceMappingURL=jobdistribution.service.js.map