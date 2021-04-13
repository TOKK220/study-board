import { BaseObject } from "@core/model/base/base-object";

export class Registration extends BaseObject {
    public name: string;
	public login: string;
	public password: string;
	public firstName: string;
	public lastName: string;
	public phoneNumber: string;
	public email: string;
}