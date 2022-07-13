export class Car {
    id: string;
    vehicleNumber: string;
    Persons: Person[]= [];
    addedOn: Date;
}

export class Person {
    name: string;
    surname: string;
    age: number;
    phoneNumber: string;
    isDriver: boolean;
}