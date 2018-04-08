import { Component, OnInit, Input } from '@angular/core';
import { Http } from '@angular/http';
import { ApiService } from '../../../shared/api.service';
import { ActivatedRoute, RouterModule, Routes, Router } from '@angular/router';
import { Feature } from '../feature';
import { ControllerEnum } from '../../../shared/enums/Controller.enum';
import { UrlEnum } from '../../../shared/enums/Urls.enum';

@Component({
    selector: 'app-feature-view',
    templateUrl: './feature-view.component.html'
})
export class FeatureViewComponent implements OnInit {
    
    @Input('ftElement') element: { Id: number, Name: string, Code: string, Description: string};

    constructor() {
    }

    ngOnInit() {

    }
}
