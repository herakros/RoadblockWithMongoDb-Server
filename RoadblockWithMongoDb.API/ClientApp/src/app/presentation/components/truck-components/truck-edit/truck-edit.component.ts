import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Person } from 'src/app/core/models/Person';
import { Truck } from 'src/app/core/models/truck-models/truck';
import { TruckService } from 'src/app/core/services/truck.service';

@Component({
  selector: 'app-truck-edit',
  templateUrl: './truck-edit.component.html',
  styleUrls: ['./truck-edit.component.css']
})
export class TruckEditComponent implements OnInit {

  formTruck: FormGroup;
  formPerson: FormGroup
  truck: Truck;
  truckId: string;

  constructor(private service: TruckService,
    private router: Router,
    private formBuidler: FormBuilder,
    private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.formTruck = this.formBuidler.group({
      truckWeight: new FormControl('', [Validators.required]),
      model: new FormControl('', [Validators.required]),
      vehicleNumber: new FormControl('', [Validators.required]),
      addedOn: new FormControl('', [Validators.required])
    });

    this.formPerson = this.formBuidler.group({
       name: new FormControl('', [Validators.required]),
       surname: new FormControl('', [Validators.required]),
       age: new FormControl('', [Validators.required]),
       phoneNumber: new FormControl('', [Validators.required])
    });

    this.activateRoute.paramMap.subscribe((p) => {
      if(p.has('id')) {
        this.truckId = p.get('id') || "";
        if(this.truckId) {
          this.service.getSingleTruck(this.truckId).subscribe((truck: Truck) => {
            this.formTruck.get('model')?.patchValue(truck.model);
            this.formTruck.get('vehicleNumber')?.patchValue(truck.vehicleNumber);
            this.formTruck.get('truckWeight')?.patchValue(truck.truckWeight);
            this.formTruck.get('addedOn')?.patchValue(truck.addedOn);

            this.formPerson.get('name')?.patchValue(truck.driver.name);
            this.formPerson.get('surname')?.patchValue(truck.driver.surname);
            this.formPerson.get('age')?.patchValue(truck.driver.age);
            this.formPerson.get('phoneNumber')?.patchValue(truck.driver.phoneNumber);
          });
        }
      }
      else {
        this.router.navigate(['/trucks']);
      }
    })
  }

  editTruck() {
    this.truck = <Truck>this.formTruck.value;
    this.truck.driver = <Person>this.formPerson.value;

    this.service.editTruck(this.truck, this.truckId).subscribe(
      () => {
        this.router.navigate(['/trucks']);
      },
      err => {
        console.log(err);
      });
  }

}
