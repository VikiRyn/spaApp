import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AccommodationCommonPage } from './pages/accommodation-common.page/accommodation-common.page';

const routes: Routes = [
  {
    path: '', 
    component: AppComponent,
    children: [
      { 
        path: 'accs',
        component: AccommodationCommonPage,
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
