import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedRoutingModule } from './shared-routing.module';
import * as fromComponents from './components';
import { CoreModule } from '@core/core.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [...fromComponents.components],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    SharedRoutingModule,
    FormsModule,
    CoreModule
  ],
  exports: [...fromComponents.components]
})
export class SharedModule { }
