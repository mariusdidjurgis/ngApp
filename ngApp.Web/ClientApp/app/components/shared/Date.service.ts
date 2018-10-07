import { Injectable } from '@angular/core';
import { Subscription, Subject, ReplaySubject, BehaviorSubject } from 'rxjs';
import * as moment from 'moment';

@Injectable()
export class DateService {
    
    constructor() {
        console.log('date Service ', this, ' moment ', moment);
    }

    public getDate(date: string): Date {
        let m = moment(date);
        
        return m.toDate();
    }

}
