import {Guid} from "guid-typescript";

export class BaseObject {
	constructor(public id: Guid = null) { }
}