import { Injectable, Injector, Input } from "@angular/core";
import { BaseControl } from "../base-control/base-control";

@Injectable()
export class BaseInputControl<T> extends BaseControl {
    @Input() placeholder: string;
    private _value: T;
	get value(): T {
		return this._value;
	}
	@Input('value')
	set value(value: T) {
		this._value = value;
		this.onValueChange();
	}
	onValueChange() {
		this.propagateChangeFn(this.value);
	}
	writeValue(obj: any): void {
		super.writeValue(obj);
		this._value = <T>obj;
	}
}