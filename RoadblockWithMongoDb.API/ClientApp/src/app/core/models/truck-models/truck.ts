import { Person } from "../Person";

export interface Truck {
    driver: Person;
    truckWeight: number;
    model: string;
    vehicleNumber: string;
    addedOn: Date;
    id: string;
}
