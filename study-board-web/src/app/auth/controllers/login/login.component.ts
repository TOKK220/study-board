import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from '@core/model/auth/login';
import { LoginRequest } from '@core/model/auth/login-request';
import { LoginResponse } from '@core/model/auth/login.response';
import { AuthService } from '@core/service/auth.service';

@Component({
  selector: 'sb-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  public login: Login = new Login();

  constructor(protected authService: AuthService, protected router: Router) { }

  public loginClick() {
    let request = this.createLoginRequest();
    this.authService.login(request).subscribe(this.onLoginSuccess);
  }
  onLoginSuccess(response: LoginResponse) {
    this.authService.setToken(response.token);
    this.router.navigate(['']);
  }
  protected createLoginRequest(): LoginRequest {
    return new LoginRequest(this.login);
  }
}
