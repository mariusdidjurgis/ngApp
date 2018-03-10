import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { WithId } from './interfces/withId.interface';
import { Router } from '@angular/router';

@Injectable()
export class ApiService {

    constructor(private http: Http, private router: Router) {
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
}
