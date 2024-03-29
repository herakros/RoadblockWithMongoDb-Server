import { Injectable } from '@angular/core';
import { carServiceUrl } from 'src/app/configs/api-endpoints';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Car } from '../models/car-models/car';

@Injectable()

export class CarService {

    constructor(private http: HttpClient) { }

    getAll() : Observable<Car[]> {
        return this.http.get<Car[]>(`${carServiceUrl}cars`);
    }

    addCar(car: Car) : Observable<void> {
        return this.http.post<void>(`${carServiceUrl}cars`, car);
    }

    deleteCar(carId: string){
        return this.http.delete(`${carServiceUrl}cars/${carId}`);
    }
}
