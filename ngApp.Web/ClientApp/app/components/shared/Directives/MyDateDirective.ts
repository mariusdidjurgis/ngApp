import { Http } from '@angular/http';
import { Injectable, Directive, Input, Output, ElementRef, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { DateService } from '../Date.service';

@Directive({
    selector: '[MyDate]'
})
export class MyDateDirective implements OnChanges {
    
    @Input() ngModel: string;
    @Output() ngModelChange: EventEmitter<any> = new EventEmitter<any>();

    @Input() time: string;
    @Output() timeChange: EventEmitter<any> = new EventEmitter<any>();

    constructor(private elem: ElementRef, private dateService: DateService) {        
        console.log('dateDirective ', this);
    }

    ngOnChanges(changes: SimpleChanges): void {
        
        let elemsToRemove = this.elem.nativeElement.parentElement.getElementsByClassName('alert-danger');
        if (elemsToRemove && elemsToRemove.length > 0) {
            for (let i = 0; i < elemsToRemove.length; i++)
                elemsToRemove[i].remove();
        }

        if (changes.time && changes.time.currentValue && !this.ngModel) {
            this.appendWarningElement("date is required");
        } else if (this.ngModel && !Date.parse(this.ngModel)) {
            this.appendWarningElement("invalid Date");
        }
    }

    private appendWarningElement(text: string) {
        let elem = document.createElement("div");
        elem.className = "badge badge-pill badge-danger alert-danger";
        elem.innerText = text;
        this.elem.nativeElement.parentElement.append(elem);
    }
    
}
