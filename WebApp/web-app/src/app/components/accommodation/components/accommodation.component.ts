import { GuestType } from './../../../entities/accommodation/models/accommodation-request.model';
import { Component, OnInit, Input } from '@angular/core';

import { Accommodation } from '../../../entities/accommodation/models/accommodation.model';
import { FormGroup, FormBuilder, FormArray } from '@angular/forms';

@Component({
  selector: 'app-accommodation',
  templateUrl: './accommodation.component.html',
  styleUrls: ['./accommodation.component.scss']
})
export class AccommodationComponent implements OnInit {
  @Input() accommodations: Accommodation[];
 
  ngOnInit() {
  }

}
