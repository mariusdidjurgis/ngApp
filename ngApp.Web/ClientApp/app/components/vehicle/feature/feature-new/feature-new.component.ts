import { Component, OnInit, Input, EventEmitter, Output, ViewEncapsulation, ContentChild, ElementRef } from '@angular/core';
import { Feature } from '../feature';

@Component({
    selector: 'app-feature-new',
    templateUrl: './feature-new.component.html',
    encapsulation: ViewEncapsulation.Emulated// Native, None 
})
export class FeatureNewComponent implements OnInit {

    model: Feature = new Feature();
    @Output('ftCreated') featureCreated = new EventEmitter<Feature>();
    @ContentChild('contentParagraph') paragraph: ElementRef;

    constructor() {
        console.log('FeatureNewComponent', this);
    }

    ngOnInit() {

    }

    Create() {
        this.featureCreated.emit(this.model);
        this.model = new Feature();
    }
}
