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
}