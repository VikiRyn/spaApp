import { Accommodation } from './../../../entities/accommodation/models/accommodation.model';
import { AccommodationService } from './../../../services/accommodation.service';
import { OnInit, Component } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-accommodation-container',
    template: `
      <app-accommodation [accommodations]="(accommodations$ | async)">
      </app-accommodation>
    `,
    styles: [`
    
    `]
  })
  export class AccommodationContainerComponent implements OnInit {
    accommodations$: Observable<Accommodation[]>;

    constructor(
      private service: AccommodationService,
    ) { }

    ngOnInit() {
      this.accommodations$ = this.service.getAll();
    }
}