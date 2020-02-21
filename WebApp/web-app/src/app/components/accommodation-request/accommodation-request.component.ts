import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';

import { GuestType } from './../../entities/accommodation/models/accommodation-request.model';

@Component({
  selector: 'app-accommodation-request',
  templateUrl: './accommodation-request.component.html',
  styleUrls: ['./accommodation-request.component.scss']
})
export class AccommodationRequestComponent implements OnInit {
  form: FormGroup;
  options: number[] = [...Array(10)].map((_, i) => i + 1);

  constructor(
    private fb: FormBuilder,
  ) {
    this.form = this.fb.group({
      location: [''],
      checkIn: [''],
      checkOut: [''],
      guests: [''],
    });

  }

  ngOnInit() {

  }

  onSubmit() {

  }
}
