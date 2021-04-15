import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthService } from './service/auth.service';
import { AuthMockService } from './service/mock/auth.mock.service';

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  exports: [],
  providers: [{ provide: AuthService, useClass: AuthMockService }]
})
export class CoreModule { }
