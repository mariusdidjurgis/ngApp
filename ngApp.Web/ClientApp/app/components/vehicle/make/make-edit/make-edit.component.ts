import { Component, OnInit } from '@angular/core';
import { Make } from '../Make';

@Component({
  selector: 'app-make-edit',
  templateUrl: './make-edit.component.html',
  styleUrls: ['./make-edit.component.css']
})
export class MakeEditComponent implements OnInit {

  title: string = "Edit make";
  model: Make = new Make(0, "new Name");
  constructor() { }

  ngOnInit() {
  }

  save(){
    console.log('save ', this);
  }
}
