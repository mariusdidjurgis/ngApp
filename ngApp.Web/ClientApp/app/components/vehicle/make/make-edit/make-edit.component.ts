import { Component, OnInit } from '@angular/core';
import { Make } from '../Make';
import { ApiService } from '../../../shared/api.service';
import { UrlEnum } from '../../../shared/enums/Urls.enum';
import { ControllerEnum } from '../../../shared/enums/Controller.enum';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-make-edit',
    templateUrl: './make-edit.component.html',
    styleUrls: ['./make-edit.component.css']
})
export class MakeEditComponent implements OnInit {
    
    model: Make = new Make(0, "", new Date(), "");
    makesUrl = UrlEnum.Make;

    constructor(private api: ApiService, private activeRoute: ActivatedRoute) { }

    ngOnInit() {
        this.GetModel();
    }

    get diagnostic() { return JSON.stringify(this.model); }

    onSubmit() {
        this.api.Save(ControllerEnum.Make, this.model, UrlEnum.Make);
        if (this.model.Id > 0)
            this.GetModel();
    }

    GetModel() {
        this.activeRoute.params.subscribe(params => {
            this.api.GetById(ControllerEnum.Make, +params['id']).subscribe(response => {
                //console.log(response.json(), new Date(response.json().Date));
                //workaround because of prime ng p-calendar cannot parse date
                this.model = new Make(response.json().Id, response.json().Name, new Date(response.json().Date), response.json().HeadQuatersLocation);
                //this.model = response.json();
            });
        });
    }
}
