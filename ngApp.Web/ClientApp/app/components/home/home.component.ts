import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { DialogService } from '../shared/Dialogs/dialog.service';
import { Observable } from 'rxjs/Observable';
import { Notification } from 'rxjs/Notification';
import { Http } from '@angular/http';
import { ControllerEnum } from '../shared/enums/Controller.enum';
import { Make } from '../vehicle/make/Make';
import 'rxjs/add/observable/of';
import { Customer } from '../shared/Types/customer';
import { CustomerComponent } from '../shared/Components/customer/customer.component';
import { UrlEnum } from '../shared/enums/Urls.enum';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
    closeResult: string;

    cars: Car[];
    cols: any[];
    public customer: Customer = new Customer();
    public test1: string = "aaa";
    public selectedUrl: UrlEnum;

    constructor(public dlgService: DialogService, private http: Http, private ref: ChangeDetectorRef) {
        //console.log(this);
    }

    test() {
        this.getobservable().subscribe(r => { console.log('r', r);});
        console.log('test',  this);
    }

    getobservable(): Observable<any>{
        var obs = Observable.of({ Id: 1, Name: "aa" });

        return obs;
    }

    ngOnInit() {
        //this.carService.getCarsSmall().then(cars => this.cars = cars);

        this.cars = [new Car("asdasd", new Date("2010-05-18"), "mybrand", "blue")];

        for (let i = 0; i < 100; i++) {
            this.cars.push(new Car("vinas" + i, new Date((1990 + i) + "-06-" + (Math.floor((Math.random() * 27))+1)), "mybrand" + i, "blue"));
        }

        this.cols = [
            { field: 'vin', header: 'Vin' },
            { field: 'year', header: 'Year' },
            { field: 'brand', header: 'Brand' },
            { field: 'color', header: 'Color' }
        ];
    }
}
class Car{
    constructor(private vin: string, private year: Date, private brand: string, private color: string) {

    }
}
