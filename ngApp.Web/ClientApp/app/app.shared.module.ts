import { ApiService } from './components/shared/api.service';
import { DialogService } from './components/shared/Dialogs/dialog.service';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { MakeComponent } from './components/vehicle/make/make.component';
import { FeatureComponent } from './components/vehicle/feature/feature.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CalendarModule } from 'primeng/calendar';
import { DropdownModule } from 'primeng/dropdown';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { MakeEditComponent } from './components/vehicle/make/make-edit/make-edit.component';
import { FeatureEditComponent } from './components/vehicle/feature/feature-edit/feature-edit.component';
import { FeatureViewComponent } from './components/vehicle/feature/feature-view/feature-view.component';
import { FeatureNewComponent } from './components/vehicle/feature/feature-new/feature-new.component';
import { ModelComponent } from './components/vehicle/model/model.component';
import { ModelEditComponent } from './components/vehicle/model/model-edit/model-edit.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        MakeComponent,
        ModelComponent,
        ModelEditComponent,
        FeatureComponent,
        MakeEditComponent,
        FeatureEditComponent,
        FeatureViewComponent,
        FeatureNewComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        BrowserAnimationsModule,
        CalendarModule,
        DropdownModule,
        NgbModule.forRoot(),
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'makes', component: MakeComponent },
            { path: 'makes/:id', component: MakeEditComponent },
            { path: 'models', component: ModelComponent },
            { path: 'models/:id', component: ModelEditComponent },
            { path: 'features', component: FeatureComponent },
            { path: 'features/:id', component: FeatureEditComponent },
            { path: '**', redirectTo: 'home' }
        ]),        
    ],
    providers: [
        ApiService,
        DialogService
    ]
})
export class AppModuleShared {
}
