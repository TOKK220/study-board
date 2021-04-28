import { Directive, Input } from '@angular/core';
import { BaseControlAccessor } from '../base-control-accessor/base-control-accessor';

@Directive()
export abstract class BaseControl extends BaseControlAccessor {
    @Input() public placeholder: string;
}
