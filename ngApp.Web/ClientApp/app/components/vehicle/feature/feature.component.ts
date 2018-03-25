import { ApiService } from './../../shared/api.service';
import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Feature } from './feature';
import { ControllerEnum } from '../../shared/enums/Controller.enum';
import { UrlEnum } from '../../shared/enums/Urls.enum';

@Component({
  selector: 'app-feature',
  templateUrl: './feature.component.html',
  styleUrls: ['./feature.component.css']
})

export class FeatureComponent implements OnInit {

    title: string = "feature list";
    features: Feature[] = [];
    featureUrl = UrlEnum.Feature;
    
    constructor(private api: ApiService, private http: Http) {
        
    }
    
    delete(Id: number) {
        this.api.Delete(ControllerEnum.Feature, Id).subscribe(x => {
            this.getList();
        });
    }
     
    ngOnInit() {
        this.getList();
    }

    select(Id: number) {
        this.features.forEach(x => { x.Selected = x.Id == Id });
    }
    
    addNewFeature(feature: Feature) {
        this.features.push(feature);
    }

    private getList() {
        this.api.GetList(ControllerEnum.Feature).subscribe(response => {
            this.features = response;
        })
    }

}
