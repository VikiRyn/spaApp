import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Accommodation } from '../entities/accommodation/models/accommodation.model';

@Injectable({
  providedIn: 'root'
})
export class AccommodationService {
  baseUrl = 'http://localhost:5000';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<Accommodation[]> {
    return this.http.get<Accommodation[]>(`${this.baseUrl}/api/accommodations`);
  }
}
