import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest} from "@angular/common/http"
import {Observable} from "rxjs";

export class AuthInterceptor implements HttpInterceptor  {
	static AuthorizedStorageKey: string  = "Token";
	static AuthorizedHeaderKey: string  = "Authorization";

	intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
		req = this.setAuthHeaders(req);
		return next.handle(req);
	}
	setAuthHeaders(req: HttpRequest<any>) : HttpRequest<any> {
		let token = AuthInterceptor.getToken();
		if (token === null) {
			return req
		}
		let config = {
			setHeaders: {}
		};
		config.setHeaders[AuthInterceptor.AuthorizedHeaderKey] = token;
		return req.clone(config);
	}
	static getToken() : string {
		return sessionStorage.getItem(AuthInterceptor.AuthorizedStorageKey) ||
			localStorage.getItem(AuthInterceptor.AuthorizedStorageKey);
	}
	static setToken(token: string, isSession: boolean) {
		if (isSession) {
			sessionStorage.setItem(AuthInterceptor.AuthorizedStorageKey, token);
		} else {
			localStorage.setItem(AuthInterceptor.AuthorizedStorageKey, token);
		}
	}
}