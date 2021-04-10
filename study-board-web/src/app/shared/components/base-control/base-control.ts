import { Injectable, Injector, OnInit } from '@angular/core';
import { BaseControlAccessor } from '../base-control-accessor/base-control-accessor';

@Injectable()
export class BaseControl extends BaseControlAccessor implements OnInit {
  ngOnInit(): void {}
}
