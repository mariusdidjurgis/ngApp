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
        //this.router.navigate([crisis.id], { relativeTo: this.route });
        console.log(this, ' route ', this.router.navigate);
    }

    ngOnInit() {
        this.GetModel();
    }

    onSubmit() {
        if (this.model.Id > 0) {
            this.api.Put("Feature", this.model).subscribe(x => {
                this.GetModel();
            })
        } else {
            this.api.Post("Feature", this.model).subscribe(x => {
               
                this.router.navigate(['/features/' + x.json()]);
                console.log(' after post', x);
            })
        }        
    }

    private GetModel() {
        this.activeRoute.params.subscribe(params => {
            this.api.GetById("Feature", +params['id']).subscribe(response => {
                this.model = response.json();
            });
        });
    }

    get diagnostic() { return JSON.stringify(this.model); }
}
