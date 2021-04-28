import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http"
import { Injectable } from "@angular/core";
import { AuthService } from "@core/service/auth.service";
import { environment } from "environment/environment";
import { Observable } from "rxjs";

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
	public AuthorizedHeaderKey: string = environment.authTokenHeaderKey;

	constructor(protected aythService: AuthService) { }

	intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
		req = this.setAuthHeaders(req);
		return next.handle(req);
	}
	setAuthHeaders(req: HttpRequest<any>): HttpRequest<any> {
		let token = this.aythService.getToken();
		if (token === null) {
			return req
		}
		let config = {
			setHeaders: {}
		};
		config.setHeaders[this.AuthorizedHeaderKey] = token;
		return req.clone(config);
	}
}