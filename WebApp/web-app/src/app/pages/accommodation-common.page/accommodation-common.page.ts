import { Component } from '@angular/core';

@Component({
  selector: 'app-accommodation-common-page',
  template: `
    <div class="container">
      <app-accommodation-request></app-accommodation-request>
      <app-accommodation-container></app-accommodation-container>
    </div>
  `,
  styles: [`
    .container {
    }
  `],
})
export class AccommodationCommonPage {

}