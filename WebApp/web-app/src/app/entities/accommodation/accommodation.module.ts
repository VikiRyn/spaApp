import { FlexLayoutModule, StyleUtils, StylesheetMap, LayoutStyleBuilder, MediaMarshaller, ɵMatchMedia, BreakPointRegistry, PrintHook, FlexStyleBuilder, ShowHideStyleBuilder, FlexOrderStyleBuilder, LayoutGapStyleBuilder } from '@angular/flex-layout';
import { AccommodationRequestComponent } from './../../components/accommodation-request/accommodation-request.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AngularMaterialModule } from './../../shared/modules/angular-material.module';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { 
  AccommodationComponent, 
  AccommodationContainerComponent 
} from '../../components/accommodation';
import { AccommodationCommonPage } from 'src/app/pages/accommodation-common.page/accommodation-common.page';

export const CONTAINERS = [
  AccommodationContainerComponent,

];

export const COMPONENTS = [
  AccommodationComponent,
  AccommodationRequestComponent,
  
];

export const PAGES = [
  AccommodationCommonPage,

];

@NgModule({
  declarations: [
    ...CONTAINERS,
    ...COMPONENTS,
    ...PAGES,
  ],
  imports: [
    CommonModule,
    AngularMaterialModule,
    ReactiveFormsModule,
    FlexLayoutModule,

  ],
  exports: [
    ...CONTAINERS,
    ...COMPONENTS,
    ...PAGES,
  ],
  providers: [
    StyleUtils,
    StylesheetMap,
    LayoutStyleBuilder,

    MediaMarshaller,
    LayoutGapStyleBuilder,
    ɵMatchMedia,
    BreakPointRegistry,
    PrintHook,
    FlexStyleBuilder,
    ShowHideStyleBuilder,
    FlexOrderStyleBuilder,

  ],
  bootstrap: []
})
export class AccommodationModule { }
