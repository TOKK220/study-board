import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Registration } from '@core/model/auth/registration';
import { AuthService } from '@core/service/auth.service';
import { Guid } from 'guid-typescript';

@Component({
  selector: 'sb-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent {
  public registration: Registration = new Registration(Guid.create());
  public confirmPassword: string;
  constructor(protected authService: AuthService, private router: Router) {}

  registrationClick() {
    this.authService.registration(this.registration).subscribe(this.onRregistrationSuccess, this.onRregistrationError);
  }
  onRregistrationSuccess() {
    this.router.navigate(['']);
  }
  onRregistrationError() {
    //todo
  }
}