import { Component, forwardRef, Injector, OnInit } from '@angular/core';
import { NG_VALUE_ACCESSOR } from '@angular/forms';
import { BaseInputControl } from '../base-input-control/base-input-control';


@Component({
  selector: 'sb-text-control',
  templateUrl: './text-control.component.html',
  styleUrls: ['./text-control.component.scss'],
  inputs: ["placeholder"],
  providers: [{
    provide: NG_VALUE_ACCESSOR,
    useExisting: forwardRef(() => TextControlComponent),
    multi: true
  }]
})
export class TextControlComponent extends BaseInputControl<string> implements OnInit {

  ngOnInit(): void {
    this.setDefaultValue();
  }

  protected setDefaultValue() {
    if (!this.value) {
      this.value = "";
    }
  }

}
