import { ApiService } from './../../shared/api.service';
import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Make } from './Make';

@Component({
  selector: 'app-make',
  templateUrl: './make.component.html',
  styleUrls: ['./make.component.css']
})
export class MakeComponent implements OnInit {

  title:string = "Make list";
  makes: Make[] = [];
  constructor(private apiService: ApiService, private http: Http) { 

  }

  ngOnInit() {
    console.log('ngoninit ', this);

    this.apiService.getList('Makes').subscribe(response => {
        this.makes = response;
    })
  }

  callWithHeaders(){
    let headers = new Headers();
    this.createAuthorizationHeader(headers);

    //this.http.get('api/Makes/Test', { headers: headers })
    //  .map(response => { 
    //    var result = response.json();
    //    console.log(' response ', response, ' result ', result);  
    //    return result;
    //   }).subscribe(function(item){ 
    //     console.log('item ', item); 
    //   });
     
  }
  createAuthorizationHeader(headers: Headers) {
    headers.append('content-type', 'application/json, text/plain, */*'); 
  }

}
