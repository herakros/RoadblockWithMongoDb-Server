export interface Person {
    name: string;
    surname: string;
    age: number;
    phoneNumber: string;
}
export interface Car {
    vehicleNumber: string;
    persons: Person[];
    addedOn: Date;
    id: string;
}
