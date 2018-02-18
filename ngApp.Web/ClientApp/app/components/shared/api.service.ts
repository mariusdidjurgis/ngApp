import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class ApiService {

  constructor(private http: Http) { 
    
  }
  
  getList(controller: string){
    return this.http.get('api/' + controller + '/GetList').map(response => response.json());
  }

}
