import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ApiService } from '../../../shared/api.service';
import { ActivatedRoute, RouterModule, Routes, Router } from '@angular/router';
import { Feature } from '../feature';
import { CommonService } from '../../../shared/Common.service';
import { ControllerEnum } from '../../../shared/enums/Controller.enum';
import { UrlEnum } from '../../../shared/enums/Urls.enum';

@Component({
    selector: 'app-feature-edit',
    templateUrl: './feature-edit.component.html',
    styleUrls: ['./feature-edit.component.css']
})
export class FeatureEditComponent implements OnInit {
    
    model: Feature = new Feature(0, "", "");
    featureUrl = UrlEnum.Feature;
    constructor(private api: ApiService, private activeRoute: ActivatedRoute, private router: Router, private http: Http) {
        console.log(this);
    }

    ngOnInit() {
        this.GetModel();
    }

    onSubmit() {
        this.api.Save(ControllerEnum.Feature, this.model, 'features');
        if (this.model.Id > 0)
            this.GetModel();
    }

    GetModel() {
        this.activeRoute.params.subscribe(params => {
            this.api.GetById(ControllerEnum.Feature, +params['id']).subscribe(response => {
                this.model = response.json();
            });
        });
    }

    get diagnostic() { return JSON.stringify(this.model); }
}
