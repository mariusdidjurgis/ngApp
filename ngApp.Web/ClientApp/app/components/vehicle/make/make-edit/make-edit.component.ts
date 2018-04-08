import { Component, OnInit } from '@angular/core';
import { Make } from '../Make';
import { ApiService } from '../../../shared/api.service';
import { UrlEnum } from '../../../shared/enums/Urls.enum';
import { ControllerEnum } from '../../../shared/enums/Controller.enum';
import { ActivatedRoute, Data } from '@angular/router';
import { CommonService } from '../../../shared/Common.service';
import { Subscription } from 'rxjs';
import { Observable } from 'rxjs/Observable';

@Component({
    selector: 'app-make-edit',
    templateUrl: './make-edit.component.html',
    styleUrls: ['./make-edit.component.css']
})
export class MakeEditComponent implements OnInit {
    
    model: Make = new Make(0, "", new Date(), "");
    makesUrl = UrlEnum.Make;
    num: number = 0;
    constructor(private api: ApiService, private activeRoute: ActivatedRoute, private common: CommonService) {
        console.log('MakeEditComponent', this, ' static data ', this.activeRoute.snapshot['data']);
    }

    ngOnInit() {

        setTimeout(() => {
            this.common.subj.subscribe(x => { console.log(' subject ', x); });
            this.common.subj2.subscribe(x => { console.log(' subjectReplay ', x); });
            this.common.subj3.subscribe(x => { console.log(' BehaviorSubject ', x); });

        }, 5000);
 

        var obs = this.common.testObservable();
        var sub = this.common.testSubscribtion();
        //obs.subscribe();
        //sub.unsubscribe();

        console.log(' observable', obs, 'subscription', sub);
        
        this.activeRoute.data.subscribe((data: Data) => {
            console.log('resolved model', data['model']);
            //this.model = data['model'];
        });

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

    test() {
        this.num++;
        this.common.subj.next("some message1" + this.num);
        this.common.subj2.next("some message2" + this.num);
        this.common.subj3.next("some message2" + this.num);
    }
}
