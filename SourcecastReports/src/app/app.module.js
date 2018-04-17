"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var jobdistribution_component_1 = require("./jobdistribution/jobdistribution.component");
var jobdistributionVoc_component_1 = require("./jobdistribution/jobdistributionVoc.component");
var home_component_1 = require("./home/home.component");
var PageNotFound_component_1 = require("./Others/PageNotFound.component");
//import { Http} from '@angular/http';
var appRoutes = [
    { path: "home", component: home_component_1.HomeComponent },
    { path: "vet", component: jobdistribution_component_1.JobDistributionComponent },
    { path: "voc", component: jobdistributionVoc_component_1.JobDistributionVocComponent },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: '**', component: PageNotFound_component_1.PageNotFoundComponent }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, http_1.HttpModule, router_1.RouterModule.forRoot(appRoutes, { useHash: true })],
            declarations: [app_component_1.AppComponent, jobdistribution_component_1.JobDistributionComponent, jobdistributionVoc_component_1.JobDistributionVocComponent, home_component_1.HomeComponent,
                PageNotFound_component_1.PageNotFoundComponent],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map