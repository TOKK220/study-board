import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './controllers/login/login.component';
import { RegistrationComponent } from './controllers/registration/registration.component';

const routes: Routes = [
	{ path: 'registration', component: RegistrationComponent },
	{ path: 'login', component: LoginComponent }
];

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule]
})
export class AuthRoutingModule { }
