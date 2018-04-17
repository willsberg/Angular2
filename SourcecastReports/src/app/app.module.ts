import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { Routes,RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { JobDistributionComponent } from './jobdistribution/jobdistribution.component';
import { JobDistributionVocComponent } from './jobdistribution/jobdistributionVoc.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './Others/PageNotFound.component';

//import { Http} from '@angular/http';

const appRoutes: Routes = [
    { path: "home", component: HomeComponent },
    { path: "vet", component: JobDistributionComponent },
    { path: "voc", component: JobDistributionVocComponent },
    { path: '', redirectTo: '/home', pathMatch:'full' }, // Default
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, HttpModule, RouterModule.forRoot(appRoutes, { useHash: true })],
    declarations: [AppComponent, JobDistributionComponent, JobDistributionVocComponent, HomeComponent,
        PageNotFoundComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
