import { Registration } from "./registration";

export class RegistrationRequest {
	public name: string;
	public login: string;
	public password: string;
	public firstName: string;
	public lastName: string;
	public phoneNumber: string;
	public email: string;

	constructor(registration: Registration) {
		this.name = registration.name;
		this.login = registration.login;
		this.password = registration.password;
		this.firstName = registration.firstName;
		this.lastName = registration.lastName;
		this.phoneNumber = registration.phoneNumber;
		this.email = registration.email;
	}
}