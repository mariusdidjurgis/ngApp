import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { WithId } from './interfces/withId.interface';
import { Router, Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import { ReplaySubject } from 'rxjs/Rx';

@Injectable()
export class ApiService {
    
    project: ReplaySubject<any> = new ReplaySubject(1);
    constructor(private http: Http, private router: Router) {
        this.project.subscribe(result => { console.log('Subscription Streaming:', result) });
    }
    
    GetList(controller: string){
        return this.http.get('api/' + controller + '/GetList').map(response => response.json());
    }

    GetById(controller: string, id: number) {
        return this.http.get('api/' + controller + '/GetById/' + id);
    }

    Post(controller: string, model: object){
        return this.http.post('api/' + controller + '/Post', model);
    }

    Put(controller: string, model: object) {
        return this.http.put('api/' + controller + '/Put', model);
    }

    Delete(controller: string, Id: number) {
        return this.http.delete('api/' + controller + '/Delete/' + Id);
    }

    Save(controller: string, model: WithId, navigationUrl: string) {
        if (model.Id > 0) {
            this.Put(controller, model).subscribe(x => {

            })
        } else {
            this.Post(controller, model).subscribe(x => {
                this.router.navigate(['/' + navigationUrl + '/' + x.json()]);
            })
        }
    }

    public observableTest(): ReplaySubject<any> {
        this.project.next(100);

        this.http.get('api/Home/GetRandomNumber').subscribe(result => {
            //push onto subject
            this.project.next(result.json());    
            //add delayed subscription AFTER loaded
            setTimeout(() => {
                this.project.subscribe(result => console.log('Delayed Stream:', result));
            }, 3000);
        });

        return this.project;
    } 

}
