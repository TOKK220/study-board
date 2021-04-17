import { Login } from "./login";

export class LoginRequest {
    public login: string;
	public password: string;

    constructor(login: Login) {
        this.login = login.login;
        this.password = login.password;
    }
}