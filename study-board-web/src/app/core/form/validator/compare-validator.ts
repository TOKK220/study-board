import { Directive, Input } from "@angular/core";
import { AbstractControl, FormGroup, NG_VALIDATORS, ValidationErrors, Validator } from "@angular/forms";
@Directive({
	selector: '[compare-validator]',
	providers: [{ provide: NG_VALIDATORS, useExisting: CompareValidator, multi: true }]
})
export class CompareValidator implements Validator {
	@Input('compareField1') compareField1: string;
	@Input('compareField2') compareField2: string;
	public validate(control: AbstractControl): ValidationErrors {
		return this.compare(this.compareField1, this.compareField2)(control);
	}
	protected compare(field1: string, field2: string) {
		return (control: AbstractControl) => {
			const field1Control = control.get(field1);
			const field2Control = control.get(field2);
			let field1Value = field1Control?.value;
			let field2Value = field2Control?.value;
			if (!field1Value || !field2Value) {
				return null;
			}
			if (field1Value !== field2Value) {
				return { notCompare: true };
			}
			return null;
		}
	}

}