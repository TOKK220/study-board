import { Injectable } from "@angular/core";
import { RegistrationRequest } from "@core/model/auth/registration-request";
import { RegistrationResponse } from "@core/model/auth/registration-response";
import { environment } from "environment/environment";
import { Observable } from "rxjs";
import { BaseHttpService } from "./base-http.service";

@Injectable()
export class AuthService extends BaseHttpService {
    private url = "/api/auth";
    public AuthorizedStorageKey: string  = environment.authTokenStorageKey;

    public registration(request: RegistrationRequest): Observable<RegistrationResponse> {
        return this.castObject(this.http.post(this.url + "/authentication/registration", request), RegistrationResponse);
    }
    public getToken() : string {
		return sessionStorage.getItem(this.AuthorizedStorageKey) ||
			localStorage.getItem(this.AuthorizedStorageKey);
	}
	public setToken(token: string, isSession: boolean) {
		if (isSession) {
			sessionStorage.setItem(this.AuthorizedStorageKey, token);
		} else {
			localStorage.setItem(this.AuthorizedStorageKey, token);
		}
	}
}