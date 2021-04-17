import { Injectable } from "@angular/core";
import { LoginRequest } from "@core/model/auth/login-request";
import { LoginResponse } from "@core/model/auth/login.response";
import { RegistrationRequest } from "@core/model/auth/registration-request";
import { RegistrationResponse } from "@core/model/auth/registration-response";
import { environment } from "environment/environment";
import { Observable } from "rxjs";
import { BaseHttpService } from "./base-http.service";

@Injectable()
export class AuthService extends BaseHttpService {
    private url = "/api/auth";
    public AuthorizedStorageKey: string  = environment.authTokenStorageKey;

	public login(request: LoginRequest): Observable<LoginResponse> {
		return this.castObject(this.http.post(this.url + "/authentication/login", request), LoginResponse);
	}
    public registration(request: RegistrationRequest): Observable<RegistrationResponse> {
        return this.castObject(this.http.post(this.url + "/authentication/registration", request), RegistrationResponse);
    }
    public isLoggedIn(): boolean {
        return !!this.getToken();
    }
    public getToken() : string {
		return sessionStorage.getItem(this.AuthorizedStorageKey) ||
			localStorage.getItem(this.AuthorizedStorageKey);
	}
	public setToken(token: string, isSession: boolean = false) {
		if (isSession) {
			sessionStorage.setItem(this.AuthorizedStorageKey, token);
		} else {
			localStorage.setItem(this.AuthorizedStorageKey, token);
		}
	}
}