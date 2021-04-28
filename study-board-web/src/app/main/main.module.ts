import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MainRoutingModule } from './main-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { MainComponent } from './components/main/main.component';
import { HomeComponent } from './components/home/home.component';
import { SharedModule } from '@shared/shared.module';
import { FormsModule } from '@angular/forms';
import { AuthModule } from 'app/auth/auth.module';
import { CoreModule } from '@core/core.module';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [MainComponent, HomeComponent],
  imports: [
    CoreModule,
    CommonModule,
    MainRoutingModule,
    BrowserModule,
    SharedModule,
    AuthModule,
    FormsModule,
    HttpClientModule
  ],
  bootstrap: [MainComponent]
})
export class MainModule { }
