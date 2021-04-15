import { Injectable } from "@angular/core";
import { Registration } from "@core/model/auth/registration";
import { Observable } from "rxjs";
import { BaseHttpService } from "./base-http.service";

@Injectable()
export class AuthService extends BaseHttpService {
    private url = "/api/auth";

    registration(date: Registration): Observable<any> {
        return this.http.post(this.url + "/authentication/registration", date);
    }
}