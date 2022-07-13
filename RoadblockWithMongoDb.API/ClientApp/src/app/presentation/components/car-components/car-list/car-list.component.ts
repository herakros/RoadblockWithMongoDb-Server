import { Component, OnInit } from '@angular/core';
import { Car } from 'src/app/core/models/car';

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.css']
})
export class CarListComponent implements OnInit {

  cars: Car[];

  constructor() { }

  ngOnInit() {
  }

  getPersonCount(id: string) : any {
    let car = this.cars.find(item => item.id === id);
    return car?.Persons.length;
  }

}
