import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedRoutingModule } from './shared-routing.module';
import * as fromComponents from './components';
import { CoreModule } from '@core/core.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PasswordControlComponent } from './components/password-control/password-control.component';

@NgModule({
  declarations: [...fromComponents.components, PasswordControlComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    CoreModule
  ],
  exports: [...fromComponents.components]
})
export class SharedModule { }
