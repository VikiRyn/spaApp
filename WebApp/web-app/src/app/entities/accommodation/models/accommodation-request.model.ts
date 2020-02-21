import { BaseModel } from './../../../shared/models/base-model';

export interface AccommodationRequest extends BaseModel {
  checkIn: Date;
  checkOut: Date;
  guests: Guest[];
}

export interface Guest {
  type: GuestType;
  number: number;
}

export enum GuestType {
  Adult = "Adult",
  Toddler = "Toddler",
  Infant = "Infant",
}