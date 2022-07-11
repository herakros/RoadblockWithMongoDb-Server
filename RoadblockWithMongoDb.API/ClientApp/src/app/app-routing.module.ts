import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarListComponent } from './presentation/components/car-components/car-list/car-list.component';
import { HomeComponent } from './presentation/components/home-component/home/home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent }
  { path: 'cars', component: CarListComponent },
];

const carRoutes: Routes = [

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
