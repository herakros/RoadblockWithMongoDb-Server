import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Car } from 'src/app/core/models/car';
import { CarService } from 'src/app/core/services/car.service';

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.css']
})
export class CarListComponent implements OnInit {

  cars: Car[];

  constructor(private service: CarService, private router: Router) { }

  ngOnInit() {
    this.service.getAll().subscribe((data: Car[]) => {
      this.cars = data;
    })
  }

  removeCar(carId: string){
    this.service.deleteCar(carId).subscribe(
      () => {
        this.router.navigate(['/cars']);
      },
      (err) => {
        console.log(err)
      }
    );
  }
}
