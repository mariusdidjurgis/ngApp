import { Component, OnInit } from '@angular/core';
import { Make } from '../Make';
import { ApiService } from '../../../shared/api.service';

@Component({
    selector: 'app-make-edit',
    templateUrl: './make-edit.component.html',
    styleUrls: ['./make-edit.component.css']
})
export class MakeEditComponent implements OnInit {

    title: string = "Create/Edit make";
    model: Make = new Make(0, "new Name", new Date(), "Vilnius");
    submitted = false;

    constructor(private apiService: ApiService) { }

    ngOnInit() {

    }

    get diagnostic() { return JSON.stringify(this.model); }

    onSubmit() {
        this.submitted = true;
        this.apiService.post('Makes', this.model).subscribe(response => {
            //this.model = new Make(0, "new Name", new Date(), "Vilnius");
        })
    }

}
