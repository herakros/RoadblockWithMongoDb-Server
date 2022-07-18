import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Car } from 'src/app/core/models/car';
import { CarService } from 'src/app/core/services/car.service';

@Component({
  selector: 'app-car-add',
  templateUrl: './car-add.component.html',
  styleUrls: ['./car-add.component.css']
})
export class CarAddComponent implements OnInit {

  form: FormGroup;
  car: Car;

  constructor(private service: CarService,
    private formBuilder: FormBuilder,
    private router: Router) { }

  ngOnInit() {
    this.form = new FormGroup({ cars: new FormArray([])});

    this.form = this.formBuilder.group({
      id: new FormControl({value: '', disabled: true}),
      vehicleNumber: new FormControl('', [Validators.required]),
      addedOn: new FormControl({value: '', disabled: true})
    });
  }

  add(){
    this.car = <Car>this.form.value;
    this.car.persons = [];

    this.service.addCar(this.car).subscribe(
      (res) => {
        this.router.navigate(['/']);
      },
      (err) => {
        console.log(err)
      }
    );
  }

}
