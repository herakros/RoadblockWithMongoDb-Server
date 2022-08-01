import { Person } from "../Person";

export interface Car {
    vehicleNumber: string;
    persons: Person[];
    addedOn: Date;
    id: string;
}
