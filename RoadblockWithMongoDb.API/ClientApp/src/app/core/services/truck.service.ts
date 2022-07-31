import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { truckServiceUrl } from "src/app/configs/api-endpoints";
import { Truck } from "../models/truck-models/truck";

@Injectable()

export class TruckService {

    constructor(private http: HttpClient) { }

    getAll() : Observable<Truck[]> {
        return this.http.get<Truck[]>(`${truckServiceUrl}trucks`);
    }

    addTruck(truck: Truck) : Observable<void> {
        return this.http.post<void>(`${truckServiceUrl}trucks`, truck)
    }

    removeTruck(truckId: string) {
        return this.http.delete(`${truckServiceUrl}trucks/${truckId}`);
    }

    editTruck(truck: Truck, id: string) : Observable<void> {
        return this.http.put<void>(`${truckServiceUrl}trucks/${id}`, truck);
    }

    getSingleTruck(truckId: string) : Observable<Truck> {
        return this.http.get<Truck>(`${truckServiceUrl}trucks${truckId}`);
    }
}