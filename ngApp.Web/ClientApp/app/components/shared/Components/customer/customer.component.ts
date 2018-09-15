import { Component, OnInit, Input, SimpleChanges, OnChanges, ChangeDetectorRef, EventEmitter, Output, OnDestroy } from '@angular/core';
import { Customer } from '../../Types/customer';
import { UrlEnum } from '../../enums/Urls.enum';
import { CommonService } from '../../Common.service';

@Component({
    selector: 'customer',
    templateUrl: './customer.component.html',
    styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit, OnChanges, OnDestroy {
 
    @Input() customer: Customer;
    @Input() test1: string;
    @Output() test1Change = new EventEmitter<string>();
    @Input() selectedUrl: UrlEnum;
    @Output() selectedUrlChange = new EventEmitter<UrlEnum>();
    private urlsArray: Array<any> = [];

    constructor(private ref: ChangeDetectorRef, private common: CommonService) {
        //console.log(this);
        this.urlsArray = this.common.urlEnumToArray();
    }
    
    ngOnChanges(changes: SimpleChanges) {
        console.log('changes', changes);
    }
        
    ngOnInit() {

    }

    ngOnDestroy(): void {
        this.selectedUrlChange.emit(undefined);
    }

    onSubmit() {

    }
}

