import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { Router, Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import { ReplaySubject } from 'rxjs/Rx';

@Injectable()
export class Customer {

    public Id: string;
    public Name: string;
    public Surname: string;
    public Birthday: Date;

    constructor() {

    }
}
