import { Component, forwardRef, Input, OnInit } from '@angular/core';
import { NgControl, NgModel, NG_VALUE_ACCESSOR } from '@angular/forms';
import { BaseInputControlComponent } from '../base-input-control/base-input-control.component';


@Component({
  selector: 'sb-text-control',
  templateUrl: '../base-input-control/base-input-control.component.html',
  styleUrls: [
    './text-control.component.scss',
    '../base-input-control/base-input-control.component.scss'
  ],
  providers: [{
    provide: NG_VALUE_ACCESSOR,
    useExisting: forwardRef(() => TextControlComponent),
    multi: true
  }]
})
export class TextControlComponent extends BaseInputControlComponent<string>  {
  ngOnInit(): void {
    super.ngOnInit();
    this.setDefaultValue();
  }

  protected setDefaultValue(): void {
    if (!this.value) {
      this.value = "";
    }
  }
  protected getInputTypeName(): string {
    return "text";
  }
}
