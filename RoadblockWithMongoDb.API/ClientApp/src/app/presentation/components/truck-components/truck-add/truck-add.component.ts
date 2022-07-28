import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Person } from 'src/app/core/models/Person';
import { Truck } from 'src/app/core/models/truck-models/truck';
import { TruckService } from 'src/app/core/services/truck.service';

@Component({
  selector: 'app-truck-add',
  templateUrl: './truck-add.component.html',
  styleUrls: ['./truck-add.component.css']
})
export class TruckAddComponent implements OnInit {

  formTruck: FormGroup;
  formPerson: FormGroup;
  truck: Truck;

  constructor(private service: TruckService,
    private formBuilder: FormBuilder,
    private router: Router) { }

  ngOnInit() {
    this.formTruck = this.formBuilder.group({
      truckWeight: new FormControl('', [Validators.required]),
      model: new FormControl('', [Validators.required]),
      vehicleNumber: new FormControl('', [Validators.required])
    });

    this.formPerson = this.formBuilder.group({
       name: new FormControl('', [Validators.required]),
       surname: new FormControl('', [Validators.required]),
       age: new FormControl('', [Validators.required]),
       phoneNumber: new FormControl('', [Validators.required])
    });
  }

  addTruck() {
    this.truck = <Truck>this.formTruck.value;
    this.truck.driver = <Person>this.formPerson.value;

    this.service.addTruck(this.truck).subscribe(
      () => {
        this.router.navigate(['/trucks']);
      },
      err => {
        console.log(err);
      }
    )
  }

}
