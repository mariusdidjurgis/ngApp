import { ApiService } from './../../shared/api.service';
import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Make } from './Make';
import { ControllerEnum } from '../../shared/enums/Controller.enum';
import { UrlEnum } from '../../shared/enums/Urls.enum';

@Component({
    selector: 'app-make',
    templateUrl: './make.component.html',
    styleUrls: ['./make.component.css']
})
export class MakeComponent implements OnInit {

    title: string = "Make list";
    makes: Make[] = [];
    makesUrl = UrlEnum.Make;
    constructor(private api: ApiService, private http: Http) {

    }    

    ngOnInit() {
        this.getList();
    }

    delete(Id: number) {
        this.api.Delete(ControllerEnum.Make, Id).subscribe(x => {
            this.getList();
        });
    }
    
    private getList() {
        this.api.GetList(ControllerEnum.Make).subscribe(response => {
            this.makes = response;
        })
    }

    callWithHeaders() {
        let headers = new Headers();
        this.createAuthorizationHeader(headers);
    }

    createAuthorizationHeader(headers: Headers) {
        headers.append('content-type', 'application/json, text/plain, */*');
    }

}
