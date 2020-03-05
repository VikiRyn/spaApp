import { CommonModule } from '@angular/common';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from "@angular/core";

import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; 

import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MAT_LABEL_GLOBAL_OPTIONS, MatRippleModule, MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

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