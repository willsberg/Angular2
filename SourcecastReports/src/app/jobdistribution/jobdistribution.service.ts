import { Injectable } from '@angular/core';
import { Http, HttpModule,Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import Jobdistribution = require("./jobdistribution");
import IJobDistribution = Jobdistribution.IJobDistribution;
import IStatus = Jobdistribution.IStatus;

//Use Injectable decorator imported from core.
@Injectable()
export class JobDistributionService {


    constructor(private http : Http){}

    geVetDistributionDetails(): Observable<IJobDistribution> {

        return this.http.get("http://172.16.0.225:85/api/jd/vet").
            map((response: Response) => <IJobDistribution>response.json());
        
    }

    geVetStatusCount(): Observable<IStatus> {

        return this.http.get("http://172.16.0.225:85/api/jd2/vet/statuscpo").
            map((response: Response) => <IStatus>response.json());

    }

    geVocDistributionDetails(): Observable<IJobDistribution> {

        return this.http.get("http://172.16.0.225:85/api/jd/voc").
            map((response: Response) => <IJobDistribution>response.json());

    }

    geVocStatusCount(): Observable<IStatus> {

        return this.http.get("http://172.16.0.225:85/api/jd2/voc/statuscpo").
            map((response: Response) => <IStatus>response.json());

    }

}