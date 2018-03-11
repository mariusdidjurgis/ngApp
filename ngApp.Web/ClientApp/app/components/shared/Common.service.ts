import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable()
export class CommonService {

    constructor(private http: Http, private router: Router) {
    }

    controllers: {
        Feature: "Feature"
    }

}
