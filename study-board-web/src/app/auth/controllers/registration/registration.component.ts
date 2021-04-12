import { Component, OnInit } from '@angular/core';
import { Registration } from '@core/auth/registration';
import { Guid } from 'guid-typescript';

@Component({
  selector: 'sb-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent {
  public registration: Registration = new Registration(Guid.create());
  public confirmPassword: string;
  ngOnInit(): void {
  }

}
