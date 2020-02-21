import { CommonModule } from '@angular/common';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from "@angular/core";

import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; 

import {  
  MatInputModule, 
  MatDatepickerModule, 
  MatButtonModule,  
  MatFormFieldModule, 
  MAT_LABEL_GLOBAL_OPTIONS,
  MatRippleModule,
  MatNativeDateModule,
  MatAutocompleteModule,
  MatCardModule
} from '@angular/material';

const MATERIAL_MODULES = [
  MatButtonModule,
  MatFormFieldModule,
  MatInputModule,
  MatRippleModule,
  MatDatepickerModule, 
  MatNativeDateModule,
  MatAutocompleteModule,
  BrowserAnimationsModule,
  MatCardModule,
];

@NgModule({
  imports: [
    CommonModule,

    ...MATERIAL_MODULES,

  ],
  exports: [
    ...MATERIAL_MODULES,

  ],
  providers: [
    MatDatepickerModule,
    {provide: MAT_LABEL_GLOBAL_OPTIONS, useValue: {float: 'always'}}
  ],
  bootstrap: [],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AngularMaterialModule { }