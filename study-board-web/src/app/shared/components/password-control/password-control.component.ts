import { Component, OnInit } from '@angular/core';
import { TextControlComponent } from '../text-control/text-control.component';

@Component({
  selector: 'sb-password-control',
  templateUrl: '../base-input-control/base-input-control.component.html',
  styleUrls: ['./password-control.component.scss']
})
export class PasswordControlComponent extends TextControlComponent {

   protected getInputTypeName(): string {
    return "password";
   }
}
