import { Http } from '@angular/http';
import { Injectable, Directive, Input, Output, ElementRef, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { DateService } from '../Date.service';

@Directive({
    selector: '[MyTime]'
})
export class MyTimeDirective implements OnChanges {
    
    @Input() ngModel: string;
    @Output() ngModelChange: EventEmitter<any> = new EventEmitter<any>();

    @Input() date: string;
    @Output() dateChange: EventEmitter<any> = new EventEmitter<any>();

    constructor(private elem: ElementRef, private dateService: DateService) {

    }

    ngOnChanges(changes: SimpleChanges): void {
        let elemsToRemove = this.elem.nativeElement.parentElement.getElementsByClassName('alert-danger');
        if (elemsToRemove && elemsToRemove.length > 0) {
            for (let i = 0; i < elemsToRemove.length; i++)
                elemsToRemove[i].remove();
        }
        
        if (changes.date && changes.date.currentValue && !this.ngModel) {
            this.appendWarningElement("time is required");
        } else if (this.ngModel && !Date.parse('1970-01-01T' + this.ngModel + 'Z')) {
            this.appendWarningElement("invalid time");
        }
    }

    private appendWarningElement(text: string) {
        let elem = document.createElement("div");
        elem.className = "badge badge-pill badge-danger alert-danger";
        elem.innerText = text;
        this.elem.nativeElement.parentElement.append(elem);
    }
}
