import { Component, Input, OnInit } from '@angular/core';
import { BaseControl } from '../base-control/base-control';

@Component({
  selector: 'sb-base-input-control',
  templateUrl: './base-input-control.component.html',
  styleUrls: ['./base-input-control.component.scss']
})
export abstract class BaseInputControlComponent<T> extends BaseControl implements OnInit {
	private _value: T;
	public type: string;

	@Input() public textPattern: string;
	@Input() public isRequired: boolean;
	@Input() public caption: string;
	@Input() public placeholder: string;
	@Input() public minlength: number;
	@Input() public maxlength: number;

	public get value(): T {
		return this._value;
	}
	@Input('value')
	public set value(value: T) {
		this._value = value;
		this.onValueChange();
	}

	ngOnInit(): void {
		this.setInputTypeName();
	}

	protected setInputTypeName(): void {
		this.type = this.getInputTypeName();
	}

	protected onValueChange() {
		if (this.propagateChangeFn) {
			this.propagateChangeFn(this.value);
		}
	}
	public writeValue(obj: any): void {
		super.writeValue(obj);
		this._value = <T>obj;
	}
	protected abstract getInputTypeName(): string;
}