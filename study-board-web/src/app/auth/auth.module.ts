import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthRoutingModule } from './auth-routing.module';
import { RegistrationComponent } from './controllers/registration/registration.component';
import { SharedModule } from '@shared/shared.module';
import { FormsModule } from '@angular/forms';
import { CompareValidator } from '@core/form/validator/compare-validator';


@NgModule({
  declarations: [
    RegistrationComponent,
    CompareValidator
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    SharedModule,
    FormsModule
  ]
})
export class AuthModule { }
