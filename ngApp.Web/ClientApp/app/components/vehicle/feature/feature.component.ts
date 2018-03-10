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
    features: Feature[] = [];

    constructor(private api: ApiService, private http: Http) {

    }

    delete(Id: number) {
        this.api.Delete("Feature", Id).subscribe(x => {
            this.getList();
        });
    }

    ngOnInit() {
        this.getList();
    }
    
    private getList() {
        this.api.GetList('Feature').subscribe(response => {
            this.features = response;
        })
    }

}
