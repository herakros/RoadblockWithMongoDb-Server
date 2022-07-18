import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Car, Person } from 'src/app/core/models/car';
import { CarService } from 'src/app/core/services/car.service';

@Component({
  selector: 'app-car-add',
  templateUrl: './car-add.component.html',
  styleUrls: ['./car-add.component.css']
})
export class CarAddComponent implements OnInit {

  formCar: FormGroup;
  formPerson: FormGroup;
  car: Car;

  constructor(private service: CarService,
    private formBuilder: FormBuilder,
    private router: Router) { }

  ngOnInit() {
    this.formCar = this.formBuilder.group({
      id: new FormControl({value: '', disabled: true}),
      vehicleNumber: new FormControl('', [Validators.required]),
      addedOn: new FormControl({value: '', disabled: true})
    });
    this.formPerson = new FormGroup({ cars: new FormArray([])});
  }

  onAddNewPerson() {
    const person = new FormGroup({
      name: new FormControl(),
      surname: new FormControl(),
      age: new FormControl(),
      phoneNumber: new FormControl(),
      isDriver: new FormControl()
    });
    (<FormArray>this.formPerson.get('cars')).push(person);
  }

  add(){
    this.car = <Car>this.formCar.value;
    this.car.persons = <Person[]>this.formPerson.value;
    this.service.addCar(this.car).subscribe(
      () => {
        this.router.navigate(['/']);
      },
      (err) => {
        console.log(err)
      }
    );
  }

  get formData(){
    return this.formPerson.get('cars') as FormArray;
  }
}
