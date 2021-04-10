import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sb-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  _value: string = "";
  get value() {
    return this._value;
  }
  set value(value: string) {
    this._value = value;
    console.log(value);
  }
  constructor() { }

  ngOnInit(): void {
  }

}
