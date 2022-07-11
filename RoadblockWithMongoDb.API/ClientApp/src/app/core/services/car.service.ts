import { Injectable } from '@angular/core';
import { carServiceUrl } from 'src/app/configs/api-endpoints';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class CarService {

private readonly carServiceUrl = carServiceUrl;

constructor(private http: HttpClient) { }

}
