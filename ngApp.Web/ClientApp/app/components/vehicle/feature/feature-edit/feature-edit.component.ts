import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ApiService } from '../../../shared/api.service';
import { ActivatedRoute, RouterModule, Routes, Router } from '@angular/router';
import { Feature } from '../feature';

@Component({
    selector: 'app-feature-edit',
    templateUrl: './feature-edit.component.html',
    styleUrls: ['./feature-edit.component.css']
})
export class FeatureEditComponent implements OnInit {
    
    model: Feature = new Feature(0, "", "");
    constructor(private api: ApiService, private activeRoute: ActivatedRoute, private router: Router, private http: Http) {
        console.log(this);
    }

    ngOnInit() {
        this.GetModel();
    }

    onSubmit() {
        this.api.Save("Feature", this.model, 'features');
        if (this.model.Id > 0)
            this.GetModel();
    }

    GetModel() {
        this.activeRoute.params.subscribe(params => {
            this.api.GetById("Feature", +params['id']).subscribe(response => {
                this.model = response.json();
            });
        });
    }

    get diagnostic() { return JSON.stringify(this.model); }
}
