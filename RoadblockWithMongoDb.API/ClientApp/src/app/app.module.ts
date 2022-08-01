import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarService } from './core/services/car.service';
import { TruckService } from './core/services/truck.service';
import { CarAddComponent } from './presentation/components/car-components/car-add/car-add.component';
import { CarEditComponent } from './presentation/components/car-components/car-edit/car-edit.component';
import { CarListComponent } from './presentation/components/car-components/car-list/car-list.component';
import { HomeComponent } from './presentation/components/home-component/home/home.component';
import { TruckAddComponent } from './presentation/components/truck-components/truck-add/truck-add.component';
import { TruckEditComponent } from './presentation/components/truck-components/truck-edit/truck-edit.component';
import { TruckListComponent } from './presentation/components/truck-components/truck-list/truck-list.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CarListComponent,
    CarAddComponent,
    CarEditComponent,
    TruckListComponent,
    TruckAddComponent,
    TruckEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [
    CarService,
    TruckService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
