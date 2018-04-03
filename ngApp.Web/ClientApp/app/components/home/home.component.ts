import { Component, OnInit } from '@angular/core';
import { DialogService } from '../shared/Dialogs/dialog.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
    closeResult: string;

    cars: Car[];
    cols: any[];

    constructor(public dlgService: DialogService) {

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
