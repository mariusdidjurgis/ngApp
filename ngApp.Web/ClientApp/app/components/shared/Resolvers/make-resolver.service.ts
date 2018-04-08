import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { Router, Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import { ReplaySubject } from 'rxjs/Rx';
import { Make } from '../../vehicle/make/Make';
import { ControllerEnum } from '../enums/Controller.enum';

@Injectable()
export class MakeResolverService implements Resolve<Make> {
    
    constructor(private http: Http, private router: Router) {

    }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Make | Observable<Make> | Promise<Make> {
        return this.http.get('api/' + ControllerEnum.Make + '/GetById/' + route.params["id"]).map(response => response.json());
    }
}
