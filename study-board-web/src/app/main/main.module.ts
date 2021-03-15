import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MainRoutingModule } from './main-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { MainComponent } from './components/main/main.component';
import { HomeComponent } from './components/home/home.component';


@NgModule({
  declarations: [MainComponent, HomeComponent],
  imports: [
    CommonModule,
    MainRoutingModule,
    BrowserModule
  ],
  bootstrap: [MainComponent]
})
export class MainModule { }
