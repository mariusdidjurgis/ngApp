import { ApiService } from './../../shared/api.service';
import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Feature } from './feature';

@Component({
  selector: 'app-feature',
  templateUrl: './feature.component.html',
  styleUrls: ['./feature.component.css']
})
export class FeatureComponent implements OnInit {

    title: string = "feature list";
    test: Feature = new Feature(1, "Name", "Code");
    url = 'http://localhost:57162/api/Students/GetById/1';

    features: Feature[] = [];
    constructor(private apiService: ApiService, private http: Http) {

    }

    ngOnInit() {

        console.log('ngoninit ', this);

        let headers = new Headers();
        headers.append('Authorization', 'Basic ' + btoa('username:password'));
        //this.createCorsHeader(headers);
        //this.http.get(this.url, {
        //    headers: headers
        //}).subscribe(x => { console.log(' xxx ', x); });

        //this.getExternalResource(this.url);

        this.apiService.getList('Feature').subscribe(response => {
            console.log(' response  ', response);
            this.features = response;
        })
    }

    //createAuthorizationHeader(headers: Headers) {
    //    headers.append('Authorization', 'Basic ' +
    //        btoa('username:password'));
    //}

    //createCorsHeader(headers: Headers) {
    //    headers.append('Access-Control-Allow-Origin', '*');
    //}

    //getExternalResource(url) {
    //    let headers = new Headers();
    //    this.createCorsHeader(headers);
    //    return this.http.get(url, {
    //        headers: headers
    //    });
    //}

}
