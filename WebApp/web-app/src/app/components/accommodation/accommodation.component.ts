import { Component, OnInit } from '@angular/core';
import { Observable } from '../../../../node_modules/rxjs';

import { AccommodationService } from './../../services/accommodation.service';
import { Accommodation } from './../../entities/accommodation/models/accommodation.model';


@Component({
  selector: 'app-accommodation',
  templateUrl: './accommodation.component.html',
  styleUrls: ['./accommodation.component.scss']
})
export class AccommodationComponent implements OnInit {
  accommodations: Observable<Accommodation[]>;

  constructor(
    private service: AccommodationService,
  ) { }

  ngOnInit() {
    this.accommodations = this.service.getAll();
    this.accommodations.subscribe(acc => console.log(acc));
  }

}
