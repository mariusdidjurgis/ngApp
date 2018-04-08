import { Component, OnInit, Input, EventEmitter, Output, ViewEncapsulation, ContentChild, ElementRef } from '@angular/core';
import { Feature } from '../feature';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-feature-new',
    templateUrl: './feature-new.component.html',
    encapsulation: ViewEncapsulation.Emulated// Native, None 
})
export class FeatureNewComponent implements OnInit {

    model: Feature = new Feature();
    @Output('ftCreated') featureCreated = new EventEmitter<Feature>();
    @ContentChild('contentParagraph') paragraph: ElementRef;

    constructor(public router: Router, public route: ActivatedRoute) {
        console.log('FeatureNewComponent', this);
    }

    ngOnInit() {

    }

    Create() {
        this.featureCreated.emit(this.model);
        this.model = new Feature();
    }

    Reload() {
        this.router.navigate(['features']);
    }
}
