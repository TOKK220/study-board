import {ControlContainer, ControlValueAccessor, FormControl, FormControlDirective} from '@angular/forms';
import {Injectable, Injector, Input, ViewChild} from '@angular/core';

@Injectable()
export class BaseControlAccessor implements ControlValueAccessor {
  protected propagateChangeFn: (_: any) => void;
  protected propagateTouchedFn: (_: any) => void;
  public isDisabled: boolean;
  public writeValue(obj: any): void {}
  public registerOnChange(fn: any): void {
    this.propagateChangeFn = fn;
  }
  public registerOnTouched(fn: any): void {
    this.propagateTouchedFn = fn;
  }
  public setDisabledState?(isDisabled: boolean): void {
    isDisabled = isDisabled;
  }
}
