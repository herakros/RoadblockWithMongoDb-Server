import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarAddComponent } from './presentation/components/car-components/car-add/car-add.component';
import { CarEditComponent } from './presentation/components/car-components/car-edit/car-edit.component';
import { CarListComponent } from './presentation/components/car-components/car-list/car-list.component';
import { HomeComponent } from './presentation/components/home-component/home/home.component';
import { TruckAddComponent } from './presentation/components/truck-components/truck-add/truck-add.component';
import { TruckListComponent } from './presentation/components/truck-components/truck-list/truck-list.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'cars', component: CarListComponent },
  { path: 'car/add', component: CarAddComponent},
  { path: 'car/edit/:id', component: CarEditComponent},
  { path: 'trucks', component: TruckListComponent },
  { path: 'truck/add', component: TruckAddComponent },
  { path: 'truck/edit/:id', component: TruckAddComponent },
  { path: '**', component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
