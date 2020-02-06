import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { AccommodationComponent } from './../../components/accommodation/accommodation.component';

export const CONTAINERS = [
  AccommodationComponent,
];

export const COMPONENTS = [
    
];

@NgModule({
  declarations: [
    ...CONTAINERS,
    ...COMPONENTS,
  ],
  imports: [
    CommonModule,
  ],
  exports: [
    ...CONTAINERS,
    ...COMPONENTS,
  ],
  providers: [

  ],
  bootstrap: []
})
export class AccommodationModule { }
