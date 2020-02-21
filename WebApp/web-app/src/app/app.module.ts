import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { FlexLayoutModule } from '@angular/flex-layout';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AngularMaterialModule } from './shared/modules/angular-material.module';
import { AccommodationModule } from './entities/accommodation/accommodation.module';

@NgModule({
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FlexLayoutModule,

    AngularMaterialModule,

    AccommodationModule,

  ],
  
  declarations: [
    AppComponent,

  ],
  providers: [

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
