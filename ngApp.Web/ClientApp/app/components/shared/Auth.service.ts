import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';

@Injectable()
export class AuthService {

    private authenticated: boolean = true;
    public Authenticated: ReplaySubject<boolean> = new ReplaySubject(1);
    constructor(private http: Http) {
    }

    Login() {
        this.authenticated = true;
        this.Authenticated.next(true);
    }

    LogOut() {
        this.authenticated = false;
        this.Authenticated.next(false);
    }

    IsAuthenticated(): Promise<boolean>{
        const promise = new Promise<boolean>((resolve, reject) => {
            setTimeout(() => {
                resolve(this.authenticated);
            }, 300)
        });

        return promise;
    }
}
