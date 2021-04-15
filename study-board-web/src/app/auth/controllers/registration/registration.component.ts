import { Component, OnInit } from '@angular/core';
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
  constructor(protected authService: AuthService) {
    
  }
  ngOnInit(): void {
  }

}
