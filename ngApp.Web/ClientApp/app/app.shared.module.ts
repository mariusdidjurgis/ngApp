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
import { CustomerComponent } from './components/shared/Components/customer/customer.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CalendarModule } from 'primeng/calendar';
import { DropdownModule } from 'primeng/dropdown';
import { TableModule } from 'primeng/table';
import { InputMaskModule } from 'primeng/inputmask';

import { MakeEditComponent } from './components/vehicle/make/make-edit/make-edit.component';
import { FeatureEditComponent } from './components/vehicle/feature/feature-edit/feature-edit.component';
import { FeatureViewComponent } from './components/vehicle/feature/feature-view/feature-view.component';
import { FeatureNewComponent } from './components/vehicle/feature/feature-new/feature-new.component';
import { ModelComponent } from './components/vehicle/model/model.component';
import { ModelEditComponent } from './components/vehicle/model/model-edit/model-edit.component';
import { AuthService } from './components/shared/Auth.service';
import { AuthGuardService } from './components/shared/auth-guard.service';
import { MakeResolverService } from './components/shared/Resolvers/make-resolver.service';
import { CommonService } from './components/shared/Common.service';
import { MyDateDirective } from './components/shared/Directives/MyDateDirective';
import { MyTimeDirective } from './components/shared/Directives/MyTimeDirective';
import { DateService } from './components/shared/Date.service';

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
        FeatureNewComponent,
        CustomerComponent,
        MyDateDirective,
        MyTimeDirective
    ],
    imports: [
        CommonModule,
        HttpModule,
        BrowserAnimationsModule,
        CalendarModule,
        DropdownModule,
        TableModule,
        InputMaskModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'makes', component: MakeComponent, canActivate: [AuthGuardService] },
            { path: 'makes/:id', component: MakeEditComponent, data: { message: "static message" }, resolve: { model: MakeResolverService } },
            { path: 'models', component: ModelComponent },
            { path: 'models/:id', component: ModelEditComponent },
            {
                path: 'features', component: FeatureComponent, children: [
                    { path: ':id', component: FeatureEditComponent },
                ]
            },            
            { path: '**', redirectTo: 'home' }
        ]),        
    ],
    providers: [
        ApiService,
        DialogService,
        AuthService,
        AuthGuardService,
        MakeResolverService,
        CommonService,
        DateService
    ],
    exports: [
        MyDateDirective,
        MyTimeDirective
    ]
})
export class AppModuleShared {
}
