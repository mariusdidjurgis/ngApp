import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ApiService } from '../../../shared/api.service';
import { ActivatedRoute, RouterModule, Routes, Router } from '@angular/router';
import { Model } from '../model';
import { CommonService } from '../../../shared/Common.service';
import { ControllerEnum } from '../../../shared/enums/Controller.enum';
import { UrlEnum } from '../../../shared/enums/Urls.enum';

@Component({
    selector: 'app-model-edit',
    templateUrl: './model-edit.component.html',
    styleUrls: ['./model-edit.component.css']
})
export class ModelEditComponent implements OnInit {

    model: Model = new Model(0, "", 0, 0);
    modelUrl = UrlEnum.Model;
    Colors: any[];
    Makes: any[];
    constructor(private api: ApiService, private activeRoute: ActivatedRoute, private router: Router, private http: Http) {
        this.http.get("api/Home/GetColors").subscribe(response => this.Colors = response.json());
        this.http.get("api/Make/GetSmallList").subscribe(response => this.Makes = response.json());
    }

    ngOnInit() {
        this.GetModel();
    }

    onSubmit() {
        console.log(' submit rtyrt',  this.model, ' this ', this);

        //return;

        this.api.Save(ControllerEnum.Model, this.model, UrlEnum.Model);
        if (this.model.Id > 0)
            this.GetModel();
    }

    GetModel() {
        this.activeRoute.params.subscribe(params => {
            this.api.GetById(ControllerEnum.Model, +params['id']).subscribe(response => {
                this.model = response.json();
            });
        });
    }

    get diagnostic() { return JSON.stringify(this.model); }
}
