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
    @Output() customerChange: EventEmitter<Customer> = new EventEmitter<Customer>();
    public tmpCustomer: Customer;
    @Input() selectedUrl: UrlEnum;
    @Output() selectedUrlChange = new EventEmitter<UrlEnum>();
    private urlsArray: Array<any> = [];

    public testModel: any = { Code: "code2" };

    public templateData: Array<any> = [
        {
            Id: 1, Visible: true, Label: 'some label', Value: '',
            Options: [{ Id: 1, Code: 'code1', Name: 'Name1' }, { Id: 2, Code: 'code2', Name: 'Name2' }, { Id: 3, Code: 'code3', Name: 'Name3' }]
        }
    ];

    constructor(private ref: ChangeDetectorRef, private common: CommonService) {
        this.urlsArray = this.common.urlEnumToArray();
    }

    save() {
        //const copy = { ...original }
        this.tmpCustomer = {} as any;
        Object.assign(this.tmpCustomer, this.customer);
    }
    
    edit() {
        this.customer = { ...this.tmpCustomer };//Object.assign({}, this.tmpCustomer);
        this.customerChange.emit(this.customer);
    }

    ngOnChanges(changes: SimpleChanges) {

    }

    ngOnInit() {

    }

    ngOnDestroy(): void {
        this.selectedUrlChange.emit(undefined);
    }

    onSubmit() {

    }
}

