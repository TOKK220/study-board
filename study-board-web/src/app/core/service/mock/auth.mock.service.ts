import { Registration } from "@core/model/auth/registration";
import { Observable } from "rxjs";
import { AuthService } from "../auth.service";
import { of } from 'rxjs';

export class AuthMockService extends AuthService{
    registration(date: Registration): Observable<any> {
        return of();
    }
}