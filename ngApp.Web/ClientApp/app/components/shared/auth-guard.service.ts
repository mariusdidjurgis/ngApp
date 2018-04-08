import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { AuthService } from './Auth.service';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router, CanActivateChild } from '@angular/router';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class AuthGuardService implements CanActivate, CanActivateChild {

    constructor(private http: Http, private auth: AuthService, private router: Router) {
    }
    
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | Observable<boolean> | Promise<boolean> {
        
        return this.auth.IsAuthenticated().then(isAuth => {
            console.log('canActivate', this, ' isAuth', isAuth);
            if (!isAuth) 
                this.router.navigate(['/']);

            return isAuth;
        })
    }

    canActivateChild(childRoute: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | Observable<boolean> | Promise<boolean> {
        return true;
    }
}
