import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class ApiService {

    constructor(private http: Http) {
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
}
