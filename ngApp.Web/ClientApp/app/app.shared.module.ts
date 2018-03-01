import { ApiService } from './components/shared/api.service';
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
import { MakeEditComponent } from './components/vehicle/make/make-edit/make-edit.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        MakeComponent,
        FeatureComponent,
        MakeEditComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        BrowserAnimationsModule,
        CalendarModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'makes', component: MakeComponent },
            { path: 'makes/:id', component: MakeEditComponent },
            { path: 'features', component: FeatureComponent },
            { path: '**', redirectTo: 'home' }
        ]),        
    ],
    providers: [
        ApiService
    ]
})
export class AppModuleShared {
}
