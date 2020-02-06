import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AccommodationComponent } from './components/accommodation/accommodation.component';

const routes: Routes = [
  {
    path: '', 
    component: AppComponent,
    children: [
      { 
        path: 'accs',
        component: AccommodationComponent,
      },
      { 
        path: '',
        redirectTo: '/accs',
        pathMatch: 'full',
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
