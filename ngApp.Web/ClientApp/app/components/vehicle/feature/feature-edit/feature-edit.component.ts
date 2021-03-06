import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ApiService } from '../../../shared/api.service';
import { ActivatedRoute, RouterModule, Routes, Router } from '@angular/router';
import { Feature } from '../feature';
import { ControllerEnum } from '../../../shared/enums/Controller.enum';
import { UrlEnum } from '../../../shared/enums/Urls.enum';

@Component({
    selector: 'app-feature-edit',
    templateUrl: './feature-edit.component.html',
    styleUrls: ['./feature-edit.component.css']
})
export class FeatureEditComponent implements OnInit {
    
    model: Feature = new Feature();
    featureUrl = UrlEnum.Feature;
    objObservable = this.api.observableTest();
    constructor(private api: ApiService, private activeRoute: ActivatedRoute, private router: Router, private http: Http) {
        this.objObservable.subscribe(x => { console.log(' subscribed in ctrl ', x); });
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

    public ObservableTest(): string {
        this.objObservable.next(Math.random());
        return "";
    }

    get diagnostic() { return JSON.stringify(this.model); }
}
