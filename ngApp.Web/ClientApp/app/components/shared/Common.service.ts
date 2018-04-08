import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription, Subject, ReplaySubject, BehaviorSubject } from 'rxjs';
import { ControllerEnum } from './enums/Controller.enum';
import { Observable } from 'rxjs/Observable';
import { Make } from '../vehicle/make/Make';

@Injectable()
export class CommonService {

    public subj = new Subject();
    public subj2 = new ReplaySubject();
    public subj3 = new BehaviorSubject('initial message');
    constructor(private http: Http, private router: Router) {
    }

    controllers: {
        Feature: "Feature"
    }

    testSubscribtion() : Subscription{
        //subscribe returns subscription
        return this.http.get('api/' + ControllerEnum.Make + '/GetById/1').subscribe((response) => {
            console.log(' resolve1', response);
        });
    }

    testObservable(): Observable<Make>{
        //map returns an observable 
        return this.http.get('api/' + ControllerEnum.Make + '/GetById/2').map((response) => {
            return response.json();
        });
    }
    
}
