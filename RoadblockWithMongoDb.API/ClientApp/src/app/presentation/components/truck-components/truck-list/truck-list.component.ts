import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Truck } from 'src/app/core/models/truck-models/truck';
import { TruckService } from 'src/app/core/services/truck.service';

@Component({
  selector: 'app-truck-list',
  templateUrl: './truck-list.component.html',
  styleUrls: ['./truck-list.component.css']
})
export class TruckListComponent implements OnInit {

  trucks: Truck[];

  constructor(private service: TruckService, private router: Router) { }

  ngOnInit() {
    this.service.getAll().subscribe((data: Truck[]) => {
      this.trucks = data;
    })
  }

  removeTruck(id: string) {
    this.service.removeTruck(id).subscribe(
      () => {
        location.reload();
      },
      err => {
        console.log(err);
      }
    )
  }

}
