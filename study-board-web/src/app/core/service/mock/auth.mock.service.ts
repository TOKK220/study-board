import { Observable } from "rxjs";
import { AuthService } from "../auth.service";
import { of } from 'rxjs';
import { RegistrationRequest } from "@core/model/auth/registration-request";
import { RegistrationResponse } from "@core/model/auth/registration-response";

export class AuthMockService extends AuthService {
    registration(request: RegistrationRequest): Observable<RegistrationResponse> {
        let response = new RegistrationResponse();
        response.token = "azaza";
        return of(response)
    }
}