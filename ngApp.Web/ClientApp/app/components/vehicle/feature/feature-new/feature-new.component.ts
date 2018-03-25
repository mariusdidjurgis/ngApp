import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Feature } from '../feature';

@Component({
    selector: 'app-feature-new',
    templateUrl: './feature-new.component.html'
})
export class FeatureNewComponent implements OnInit {

    model: Feature = new Feature(0, "", "", "");
    @Output() featureCreated = new EventEmitter<Feature>();

    constructor() {

    }

    ngOnInit() {

    }

    Create() {
        this.featureCreated.emit(this.model);
        this.model = new Feature(0, "", "", "");
    }
}
