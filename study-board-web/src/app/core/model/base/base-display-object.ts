import { Guid } from "guid-typescript";
import { BaseObject } from "./base-object";

export class BaseDisplayObject extends BaseObject {
	constructor(id: Guid = null, public name: string = null) {
		super(id);
	}
}