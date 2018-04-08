import { Component } from '@angular/core';
import { AuthService } from '../shared/Auth.service';

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html',
    styleUrls: ['./navmenu.component.css']
})
export class NavMenuComponent {

    authenticated: boolean;
    constructor(private auth: AuthService) {
        auth.Authenticated.subscribe(x => {
            this.authenticated = x;
        });
    }

    login(evt: any) {
        this.auth.Login();
    }

    logout(evt: any) {
        this.auth.LogOut();
    }
    
}
