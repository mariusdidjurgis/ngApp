import { ApiService } from './../../shared/api.service';
import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Make } from './Make';

@Component({
  selector: 'app-make',
  templateUrl: './make.component.html',
  styleUrls: ['./make.component.css']
})
export class MakeComponent implements OnInit {

  title:string = "Make list";
  makes: Make[] = [];
  constructor(private apiService: ApiService, private http: Http) { 

    new Make(1, 'LTL');
  }

  ngOnInit() {
    console.log('ngoninit ', this);
    this.apiService.getList('Makes').subscribe(response => {
        this.makes = response;
    })

  }

}
