import { BaseModel } from './../../../shared/models/base-model';

export interface Accommodation extends BaseModel {
    name: string;
    location: string;
    type: string;
    numberOfGuests: number;
    price: number;
}