import { ApiService } from './../../shared/api.service';
import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Model } from './Model';
import { ControllerEnum } from '../../shared/enums/Controller.enum';
import { UrlEnum } from '../../shared/enums/Urls.enum';

@Component({
    selector: 'app-model',
    templateUrl: './model.component.html',
    styleUrls: ['./model.component.css']
})
export class ModelComponent implements OnInit {
    
    models: Model[] = [];
    modelsUrl = UrlEnum.Model;
    constructor(private api: ApiService, private http: Http) {

    }    

    ngOnInit() {
        this.getList();
    }

    delete(Id: number) {
        this.api.Delete(ControllerEnum.Model, Id).subscribe(x => {
            this.getList();
        });
    }
    
    private getList() {
        this.api.GetList(ControllerEnum.Model).subscribe(response => {
            this.models = response;
        })
    }
    
}
