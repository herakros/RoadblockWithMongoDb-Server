export interface Person {
    name: string;
    surname: string;
    age: number;
    phoneNumber: string;
    isDriver: boolean;
}
export interface Car {
    vehicleNumber: string;
    persons: Person[];
    addedOn: Date;
    id: string;
}