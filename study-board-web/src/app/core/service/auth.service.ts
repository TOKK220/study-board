import { Injectable } from "@angular/core";
import { RegistrationRequest } from "@core/model/auth/registration-request";
import { RegistrationResponse } from "@core/model/auth/registration-response";
import { Observable } from "rxjs";
import { BaseHttpService } from "./base-http.service";

@Injectable()
export class AuthService extends BaseHttpService {
    private url = "/api/auth";

    registration(request: RegistrationRequest): Observable<RegistrationResponse> {
        return this.castObject(this.http.post(this.url + "/authentication/registration", request), RegistrationResponse);
    }
}