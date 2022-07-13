import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarService } from './core/services/car.service';
import { CarListComponent } from './presentation/components/car-components/car-list/car-list.component';
import { HomeComponent } from './presentation/components/home-component/home/home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CarListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    CarService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
