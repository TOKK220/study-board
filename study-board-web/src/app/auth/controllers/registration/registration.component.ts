import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Registration } from '@core/model/auth/registration';
import { RegistrationRequest } from '@core/model/auth/registration-request';
import { RegistrationResponse } from '@core/model/auth/registration-response';
import { AuthService } from '@core/service/auth.service';

@Component({
  selector: 'sb-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent {
  public registration: Registration = new Registration();
  public confirmPassword: string;
  constructor(protected authService: AuthService, protected router: Router) {}

  registrationClick() {
    let request = this.createRegistrationRequest();
    this.authService.registration(request).subscribe(this.onRregistrationSuccess);
  }
  createRegistrationRequest(): RegistrationRequest {
    return new RegistrationRequest(this.registration);
  }
  onRregistrationSuccess(response: RegistrationResponse) {
    this.authService.setToken(response.token);
    this.router.navigate(['']);
  }
}