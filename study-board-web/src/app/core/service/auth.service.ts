import { Injectable } from "@angular/core";
import { LoginRequest } from "@core/model/auth/login-request";
import { LoginResponse } from "@core/model/auth/login.response";
import { RegistrationRequest } from "@core/model/auth/registration-request";
import { RegistrationResponse } from "@core/model/auth/registration-response";
import { environment } from "environment/environment";
import { Observable } from "rxjs";
import { BaseHttpService } from "./base-http.service";

@Injectable({
	providedIn: "root"
})
export class AuthService extends BaseHttpService {
	private url = "/api/auth";
	public authorizedStorageKey: string = environment.authTokenStorageKey;
	public isSession: boolean = false;
	public login(request: LoginRequest): Observable<LoginResponse> {
		return this.castObject(this.http.post(this.url + "/authentication/login", request), LoginResponse);
	}
	public registration(request: RegistrationRequest): Observable<RegistrationResponse> {
		return this.castObject(this.http.post(this.url + "/authentication/registration", request), RegistrationResponse);
	}
	public isLoggedIn(): boolean {
		return !!this.getToken();
	}
	public getToken(): string {
		if (this.isSession) {
			return this.getSessionToken();
		}
		return this.getLocalToken();
	}
	public setToken(token: string) {
		if (this.isSession) {
			this.setSessionToken(token);
		} else {
			this.setLocalToken(token);
		}
	}
	protected setSessionToken(token: string): void {
		sessionStorage.setItem(this.authorizedStorageKey, token);
	}
	protected setLocalToken(token: string): void {
		localStorage.setItem(this.authorizedStorageKey, token);
	}
	protected getSessionToken(): string {
		return sessionStorage.getItem(this.authorizedStorageKey);
	}
	protected getLocalToken(): string {
		return localStorage.getItem(this.authorizedStorageKey);
	}
}