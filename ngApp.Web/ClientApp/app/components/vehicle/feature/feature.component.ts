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

    features: Feature[] = [];
    constructor(private apiService: ApiService, private http: Http) {

    }

    ngOnInit() {
        console.log('ngoninit ', this);

        this.apiService.getList('Feature').subscribe(response => {
            console.log(' response  ', response);
            this.features = response;
        })
    }
}
